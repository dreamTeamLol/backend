using AutoMapper;
using DreamDirectum.Core.Factories;
using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Configuration;
using DreamDirectum.Core.Models.MappingProfiles;
using DreamDirectum.Core.Services;
using DreamDirectum.Infrastructure.Repositories.EmployeeRepositories;
using DreamDirectum.Infrastructure.Repositories.MeetingRepositories;
using DreamDirectum.Infrastructure.Repositories.SubstitutionRepositories;
using DreamDirectum.UseCases;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.CoreEntities;
using Sungero.IntegrationService.Models.Generated.EmployeeMutationsModule;
using Sungero.IntegrationService.Models.Generated.Meetings;
using Sungero.IntegrationService.Models.Generated.NewDreamSolution;

namespace DreamDirectum.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var directumConfiguration = builder.Configuration.GetSection("Directum");
            builder.Services.Configure<DirectumConfiguration>(directumConfiguration);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowAll",
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader()
                                      .AllowAnyHeader();
                                  });

                options.AddPolicy(name: "AllowDomainOnly",
                                  builder =>
                                  {
                                      builder.WithOrigins("https://directum.snedson.com/")
                                      .SetIsOriginAllowed(a => true)
                                      .AllowCredentials()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader()
                                      .WithExposedHeaders("Access-Control-Allow-Credentials");
                                  });
            });

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            if (context.Request.Cookies.TryGetValue("directum-token", out string accessToken))
                            {
                                context.Token = accessToken;
                            }
                            return Task.CompletedTask;
                        }
                    };
                });


            builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EmployeeProfile());
                cfg.AddProfile(new MutationRecordProfile());
                cfg.AddProfile(new SubstitutionProfile());
                cfg.AddProfile(new MeetingProfile());
            }).CreateMapper());

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<MediatrPing>());

            builder.Services.AddScoped<IUserAuthTokenService, UserAuthTokenService>();
            builder.Services.AddScoped<ITokenOptionsFactory, TokenOptionsFactory>();

            builder.Services.AddScoped<IReadOnlyPaginalRepository<IEmployeeDto, long>, EmployeeRepository>();
            builder.Services.AddScoped<IReadOnlyRepository<IEmployeeDto, long>, EmployeeRepository>();
            builder.Services.AddScoped<IReadOnlySinglePageRepository<IEmployeeDto, long>, EmployeeRepository>();

            builder.Services.AddScoped<IReadOnlyPaginalRepository<IEmployeeMutationsLogDto, long>, EmployeeMutationLogRepository>();
            builder.Services.AddScoped<IReadOnlyRepository<IEmployeeMutationsLogDto, long>, EmployeeMutationLogRepository>();

            builder.Services.AddScoped<IReadOnlyPaginalRepository<ISubstitutionDto, long>, SubstitutionRepository>();
            builder.Services.AddScoped<IReadOnlyRepository<ISubstitutionDto, long>, SubstitutionRepository>();

            builder.Services.AddScoped<IReadOnlyPaginalRepository<IMeetingDto, long>, MeetingRepository>();
            builder.Services.AddScoped<IReadOnlyRepository<IMeetingDto, long>, MeetingRepository>();

            builder.Services.AddScoped((sp) => new Container(new Uri("https://drim-student.starkovgrp.ru/Integration/odata/")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{ 
                app.UseSwagger();
                app.UseSwaggerUI();
            //}

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
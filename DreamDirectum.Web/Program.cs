
using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Configuration;
using DreamDirectum.Core.Services;
using DreamDirectum.Infrastructure.Repositories;
using DreamDirectum.UseCases.Queries.EmployeeQueries;
using Microsoft.Extensions.Configuration;
using Sungero.IntegrationService;
using System.Net.NetworkInformation;
using System.Reflection;

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

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAllEmployeesQuery>());

            builder.Services.AddScoped<IUserAuthTokenService, UserAuthTokenService>();
            builder.Services.AddScoped<EmployeeRepository>();
            builder.Services.AddScoped<EmployeeMutationKindRepository>();
            builder.Services.AddScoped((sp) => new Container(new Uri("https://drim-student.starkovgrp.ru/Integration/odata/")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
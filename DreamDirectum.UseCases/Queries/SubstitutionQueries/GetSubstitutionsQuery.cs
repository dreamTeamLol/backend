using AutoMapper;
using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Dtos;
using MediatR;
using Sungero.IntegrationService.Models.Generated.CoreEntities;

namespace DreamDirectum.UseCases.Queries.SubstitutionQueries
{
    public class GetSubstitutionsQuery : IRequest<SubstitutionDto[]>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }

    public class GetSubstitutionsQueryHandler : AbstractHandler, IRequestHandler<GetSubstitutionsQuery, SubstitutionDto[]>
    {
        private readonly IReadOnlyPaginalRepository<ISubstitutionDto, long> substitutionRepository;

        public GetSubstitutionsQueryHandler
            (IUserAuthTokenService userAuthToken, 
            IMapper mapper,
            IReadOnlyPaginalRepository<ISubstitutionDto, long> substitutionRepository) : base(userAuthToken, mapper)
        {
            this.substitutionRepository = substitutionRepository;
        }

        public async Task<SubstitutionDto[]> Handle(GetSubstitutionsQuery request, CancellationToken cancellationToken)
        {
            var result = await substitutionRepository
                .GetAllWithPaginationAsync
                (userAuthToken.AuthToken,
                request.Limit,
                request.Offset,
                cancellationToken);

            return mapper.Map<IEnumerable<ISubstitutionDto>, SubstitutionDto[]>(result);
        }
    }
}

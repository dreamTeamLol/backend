using AutoMapper;
using DreamDirectum.Core.Interfaces;

namespace DreamDirectum.UseCases
{
    public abstract class AbstractHandler
    {
        protected readonly IUserAuthTokenService userAuthToken;
        protected readonly IMapper mapper;

        public AbstractHandler(IUserAuthTokenService userAuthToken, IMapper mapper)
        {
            this.userAuthToken = userAuthToken;
            this.mapper = mapper;
        }
    }
}

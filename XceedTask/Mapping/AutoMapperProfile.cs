using AutoMapper;
using Microsoft.AspNetCore.Identity;
using XceedTask.ViewModels;

namespace XceedTask.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterUserVM, IdentityUser>();

        }
    }
}

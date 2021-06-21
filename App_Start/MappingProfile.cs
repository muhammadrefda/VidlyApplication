using AutoMapper;
using VidlyApplication.Dtos;
using VidlyApplication.Models;

namespace VidlyApplication.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
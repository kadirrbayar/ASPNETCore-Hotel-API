using AutoMapper;
using EntityLayer.Concrete;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.ServiceDto;
using WebUI.Dtos.StaffDto;
using WebUI.Dtos.SubscribeDto;
using WebUI.Dtos.TestimonialDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<ServiceDto, Service>().ReverseMap();
            
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<TestimonialDto, Testimonial>().ReverseMap();
       
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<RoomDto, Room>().ReverseMap();
     
            CreateMap<CreateStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            CreateMap<StaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<SubscribeDto, Subscribe>().ReverseMap();

            CreateMap<RegisterDto, DbUser>().ReverseMap();
        }
    }
}

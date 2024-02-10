using AutoMapper;
using EntityLayer.Concrete;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.ContactDto;
using WebUI.Dtos.GuestDto;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.ServiceDto;
using WebUI.Dtos.StaffDto;
using WebUI.Dtos.SubscribeDto;
using WebUI.Dtos.TestimonialDto;
using WebUI.Dtos.TutorialDto;

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

            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<AboutDto, About>().ReverseMap();

            CreateMap<CreateTutorialDto, Tutorial>().ReverseMap();
            CreateMap<UpdateTutorialDto, Tutorial>().ReverseMap();
            CreateMap<TutorialDto, Tutorial>().ReverseMap();
            
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();
            CreateMap<BookingDto, Booking>().ReverseMap();
            
            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<ContactDto, Contact>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<GuestDto, Guest>().ReverseMap();
        }
    }
}

using AutoMapper;
using DtoLayer.Dtos.AboutDto;
using DtoLayer.Dtos.BookingDto;
using DtoLayer.Dtos.ContactDto;
using DtoLayer.Dtos.GuestDto;
using DtoLayer.Dtos.RoomDto;
using DtoLayer.Dtos.ServiceDto;
using DtoLayer.Dtos.StaffDto;
using DtoLayer.Dtos.SubscribeDto;
using DtoLayer.Dtos.TestimonialDto;
using DtoLayer.Dtos.TutorialDto;
using EntityLayer.Concrete;
using System.Runtime;

namespace WebAPI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();

            CreateMap<CreateStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();

            CreateMap<CreateTutorialDto, Tutorial>().ReverseMap();
            CreateMap<UpdateTutorialDto, Tutorial>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

        }
    }
}

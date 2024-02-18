using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.GuestDto;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.ContactDto;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.SendMessageDto;
using WebUI.Dtos.ServiceDto;
using WebUI.Dtos.StaffDto;
using WebUI.Dtos.SubscribeDto;
using WebUI.Dtos.TestimonialDto;
using WebUI.Dtos.TutorialDto;
using WebUI.ValidationRules.AboutValidation;
using WebUI.ValidationRules.BookingValidation;
using WebUI.ValidationRules.ContactValidation;
using WebUI.ValidationRules.LoginValidation;
using WebUI.ValidationRules.GuestValidation;
using WebUI.ValidationRules.RegisterValidation;
using WebUI.ValidationRules.RoomValidation;
using WebUI.ValidationRules.SendMessage;
using WebUI.ValidationRules.ServiceValidation;
using WebUI.ValidationRules.StaffValidation;
using WebUI.ValidationRules.SubscribeValidation;
using WebUI.ValidationRules.TestimonialValidation;
using WebUI.ValidationRules.TutorialValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using WebUI.ValidationRules.MessageCategoryValidation;
using WebUI.Dtos.MessageCategoryDto;
using WebUI.Dtos.RoleDto;
using WebUI.ValidationRules.RoleValidation;
using WebUI.Dtos.DbUserDto;
using WebUI.ValidationRules.DbUserValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<DbUser, DbRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromHours(1);
    options.LoginPath = "/Login/Index/";
});
builder.Services.AddTransient<IValidator<UpdateAboutDto>, UpdateAboutValidator>();
builder.Services.AddTransient<IValidator<CreateBookingDto>, CreateBookingValidator>();
builder.Services.AddTransient<IValidator<UpdateBookingDto>, UpdateBookingValidator>();
builder.Services.AddTransient<IValidator<CreateContactDto>, CreateContactValidator>();
builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
builder.Services.AddTransient<IValidator<LoginDto>, CreateLoginValidator>();
builder.Services.AddTransient<IValidator<RegisterDto>, CreateRegisterValidator>();
builder.Services.AddTransient<IValidator<CreateRoomDto>, CreateRoomValidator>();
builder.Services.AddTransient<IValidator<UpdateRoomDto>, UpdateRoomValidator>();
builder.Services.AddTransient<IValidator<CreateSendMessageDto>, CreateSendMessageValidator>();
builder.Services.AddTransient<IValidator<CreateServiceDto>, CreateServiceValidator>();
builder.Services.AddTransient<IValidator<UpdateServiceDto>, UpdateServiceValidator>();
builder.Services.AddTransient<IValidator<CreateStaffDto>, CreateStaffValidator>();
builder.Services.AddTransient<IValidator<UpdateServiceDto>, UpdateServiceValidator>();
builder.Services.AddTransient<IValidator<CreateStaffDto>, CreateStaffValidator>();
builder.Services.AddTransient<IValidator<UpdateStaffDto>, UpdateStaffValidator>();
builder.Services.AddTransient<IValidator<CreateSubscribeDto>, CreateSubscribeValidator>();
builder.Services.AddTransient<IValidator<UpdateSubscribeDto>, UpdateSubscribeValidator>();
builder.Services.AddTransient<IValidator<CreateTestimonialDto>, CreateTestimonialValidator>();
builder.Services.AddTransient<IValidator<UpdateTestimonialDto>, UpdateTestimonialValidator>();
builder.Services.AddTransient<IValidator<CreateTutorialDto>, CreateTutorialValidator>();
builder.Services.AddTransient<IValidator<UpdateTutorialDto>, UpdateTutorialValidator>();
builder.Services.AddTransient<IValidator<CreateMessageCategoryDto>, CreateMessageCategoryValidator>();
builder.Services.AddTransient<IValidator<UpdateMessageCategoryDto>, UpdateMessageCategoryValidator>();
builder.Services.AddTransient<IValidator<CreateRoleDto>, CreateRoleValidator>();
builder.Services.AddTransient<IValidator<UpdateRoleDto>, UpdateRoleValidator>();
builder.Services.AddTransient<IValidator<UpdateDbUserDto>, UpdateDbUserValidator>();

builder.Services.AddControllersWithViews().AddFluentValidation();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

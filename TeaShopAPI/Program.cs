using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.BusinessLayer.Concrete;
using TeaShopAPI.DataAccess.Abstract;
using TeaShopAPI.DataAccess.Context;
using TeaShopAPI.DataAccess.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDrinkDal, EfDrinkDal>();
builder.Services.AddScoped<IDrinkService, DrinkManager>();

builder.Services.AddScoped<IMessageDal, EfMessageDal>();
builder.Services.AddScoped<IMessageService, MessageManager>();

builder.Services.AddScoped<IQuestionDal, EfQuestionDal>();
builder.Services.AddScoped<IQuestionService, QuestionManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IStatisticDal, EfStatisticDal>();
builder.Services.AddScoped<IStatisticService, StatisticManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IOurTeaShopDal, EfOurTeaShopDal>();
builder.Services.AddScoped<IOurTeaShopService, OurTeaShopManager>();

builder.Services.AddScoped<IReservationDal, EfReservationDal>();
builder.Services.AddScoped<IReservationService, ReservationManager>();

builder.Services.AddScoped<ISliderDal, EfSliderDal>();
builder.Services.AddScoped<ISliderService, SliderManager>();

builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddDbContext<TeaContext>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

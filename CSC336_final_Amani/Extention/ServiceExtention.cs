using BLL.Services.Airplanes;
using BLL.Services.Flights;
using BLL.Services.Passengers;
using BLL.Services.Pilots;
using BLL.Services.Reservations;

namespace CSC336_final_Amani.Extention
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IPassengerService, PassengerService>();
            service.AddScoped<IPilotService, PilotService>();
            service.AddScoped<IAirplaneService, AirplaneService>();
            service.AddScoped<IFlightService, FlightService>();
            service.AddScoped<IReservationService, ReservationService>();



            return service;

        }
    }
}

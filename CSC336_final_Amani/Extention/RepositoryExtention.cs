using DAL.Repositories.Airplanes;
using DAL.Repositories.Flights;
using DAL.Repositories.Passengers;
using DAL.Repositories.Pilots;
using DAL.Repositories.Reservations;

namespace CSC336_final_Amani.Extention
{
    public static class RepositoryExtention
    {
        public static IServiceCollection AddRepositoty(this IServiceCollection service)
        {
            service.AddScoped<IPilotRepository, PilotRepository>();
            service.AddScoped<IPassengerRepository, PassengerRepository>();
            service.AddScoped<IReservationRepository, ReservationRepository>();
            service.AddScoped<IFlightRepository, FlightRepository>();
            service.AddScoped<IAirplaneRepository, AirplaneRepository>();





            return service;
        }
    }
}

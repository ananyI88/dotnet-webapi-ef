using dotnet_webapi.DTOs;
using dotnet_webapi_ef.Mappers;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi.Mappers
{
    public static class TripMapper
    {
        public static TripDTOs ToTripDTO( this Trip trip){
            return new TripDTOs{
                Idx = trip.Idx,
                Name = trip.Name,
                Country = trip.Country,
                Destination = trip.Destination.ToDestinationDTO(),
                Coverimage = trip.Coverimage,
                Detail = trip.Detail,
                Price = trip.Price,
                Duration = trip.Duration,
                Destinationid = trip.Destinationid
            };
        }
    }
}
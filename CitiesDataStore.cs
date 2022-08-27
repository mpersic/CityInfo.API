using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        #region Constructors

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "Central Park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Big park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Apple",
                            Description = "Very big apple"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Slatina",
                    Description = "Fontana",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Fontana",
                            Description = "Water"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Zagreb",
                    Description = "Sljeme",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Sljeme",
                            Description = "Skiing"
                        }
                    }
                },
            };
        }

        #endregion Constructors

        #region Properties

        //public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        #endregion Properties
    }
}
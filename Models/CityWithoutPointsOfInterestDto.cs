namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO for a city without points of interest
    /// </summary>
    public class CityWithoutPointsOfInterestDto
    {
        #region Properties

        public string? Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        #endregion Properties
    }
}
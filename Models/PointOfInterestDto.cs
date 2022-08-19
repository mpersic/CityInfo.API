namespace CityInfo.API.Models
{
    public class PointOfInterestDto
    {
        #region Properties

        public string? Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        #endregion Properties
    }
}
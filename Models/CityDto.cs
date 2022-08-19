namespace CityInfo.API.Models
{
    public class CityDto
    {
        #region Properties

        public string? Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();

        #endregion Properties
    }
}
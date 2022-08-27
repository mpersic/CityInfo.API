using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        #region Constructors

        public PointOfInterest(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Properties

        [ForeignKey("CityId")]
        public City? City { get; set; }

        public int CityId { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        #endregion Properties
    }
}
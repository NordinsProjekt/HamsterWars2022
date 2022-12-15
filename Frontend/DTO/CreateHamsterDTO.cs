using System.ComponentModel.DataAnnotations;

namespace Frontend.DTO
{
    public class CreateHamsterDTO
    {
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required,Range(1,15)]
        public int Age { get; set; }
        [Required, MaxLength(100)]
        public string FavFood { get; set; }
        [Required, MaxLength(100)]
        public string Loves { get; set; }
        [Required, MaxLength(100)]
        public string ImgName { get; set; }
    }
}

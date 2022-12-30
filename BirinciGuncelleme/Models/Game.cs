using System.ComponentModel.DataAnnotations;
using WebProje.Data.Enum;

namespace WebProje.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GameCategory GameCategory { get; set; }
        public double Price { get; set; }

        public string Image { get; set; }




    }
}

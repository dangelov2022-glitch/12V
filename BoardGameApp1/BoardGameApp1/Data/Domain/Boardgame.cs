using System.ComponentModel.DataAnnotations;

namespace BoardGameApp1.Data.Domain
{
    public class Boardgame
        
    {
      public int Id { get; set; }
        public string Name { get; set; } 

        public double Rating { get; set; }
        public int YearPublished { get; set; }
        public string CategoryType { get; set; }

        public string? Mechanics { get; set; }
        public int CreatorId { get; set; }




    }
}

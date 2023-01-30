using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieApp.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]

        public  Movie Movie { get; set; }

        public int OrderID { get; set; }
        [ForeignKey("OrderID")]

        public Order Order { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowMetrics.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; } // Primary Key

        [ForeignKey("Client")]
        public int ClientId { get; set; } // Foreign Key with Client Table

        public string Name { get; set; } // Remove 'required' keyword

        public string? MobileNo { get; set; } = null;

        // Navigation property
        public Client? Client { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geroy.Models
{
    public class InventoryModel
    {
        public class Campus
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }

            public string? CampusName { get; set; }
        }

        public class User
        {
            public int Id { get; set; }
            public string? Username { get; set; }
            public string? Password { get; set; }
        }
    }
}
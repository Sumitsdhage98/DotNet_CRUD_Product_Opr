using System.ComponentModel.DataAnnotations;

namespace NimapAppProject.Models
{
    public class Product
    {

        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public string CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}

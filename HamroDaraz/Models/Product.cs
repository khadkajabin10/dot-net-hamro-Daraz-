namespace HamroDaraz.Models
{
    public class Product
    {
        public int Id { get; set; }                 // Primary Key
        public string Title { get; set; }           // Product title
        public string Description { get; set; }     // Product description
        public int Price { get; set; }              // Product price
        public string? ProductIcon { get; set; }     // Image or icon path

  
        public int CategoryId { get; set; }

       
        public virtual Category? Category { get; set; }
    }
}

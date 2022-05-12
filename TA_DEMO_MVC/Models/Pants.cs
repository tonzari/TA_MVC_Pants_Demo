namespace TA_DEMO_MVC.Models
{
    public class Pants
    {
        public Pants(string brand, string size, string color)
        {
            Brand = brand;
            Size = size;
            Color = color;
        }

        public int ID { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
    }
}

namespace Pronia.Models
{
    public class Slider
    {
         public int Id { get; set; }
         public string MainTitle { get; set; }
         public string Title { get; set; }
         public string  Description { get; set; }
         public string ImageUrl  { get; set; }
         public string BtnText   { get; set; }
         public string BtnUrl { get; set; }

         public int Order { get; set; }
            
    }
}

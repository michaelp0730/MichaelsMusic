using System.Web;

namespace MichaelsMusic.Models
{
    public class Item
    {
        // TODO: Create enum for type property (ex: Guitar, Amp, Pedal)
        public bool IsMine { get; set; }
        public bool WasMine { get; set; }
        public decimal Cost { get; set; }
        public IHtmlString FeaturedImage { get; set; }
        public IHtmlString[] Images { get; set; }
        public IHtmlString Thumbnail { get; set; }
        public int YearBuilt { get; set; }
        public Link[] Links { get; set; }
        public Link[] VideoLinks { get; set; }
        public string ArtistName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string ModelName { get; set; }
        public string ShortDescription { get; set; }
        public string Slug { get; set; }
    }
}
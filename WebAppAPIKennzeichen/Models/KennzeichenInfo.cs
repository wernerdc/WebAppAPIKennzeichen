namespace WebAppAPIKennzeichen.Models
{
    public class KennzeichenInfo
    {
        public int Id { get; set; }
        public string Kennzeichen { get; set; }
        public string Ort { get; set; }
        public string Kreis { get; set; }
        public string Bundesland { get; set; }
        public string WappenLink { get; set; }
    }
}

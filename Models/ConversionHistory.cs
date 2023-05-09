namespace UKE_api.Models
{
    public class ConversionHistory
    {
        public int Id { get; set; }
        public string RomanNumeral { get; set; }
        public int NormalNumber { get; set; }
        public DateTime ConversionTime { get; set; }
    }
}

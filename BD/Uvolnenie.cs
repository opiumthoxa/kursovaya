
namespace Praktica
{
    public class Uvolnenie
    {
        public int Id { get; set; }
        public int? SotrudnikId { get; set; }
        public DateTime? DataUvolnenia { get; set; }
        public string? Prichina { get; set; }
        public Sotrudnik? Sotrudnik { get; set; }
    }
}

using Praktica;
namespace Praktica
{
    public class Komandirovka
    {
        public int Id { get; set; }
        public int? SotrudnikId { get; set; }
        public int? SrokVSutkah { get; set; }
        public string? Mesto { get; set; }
        public Sotrudnik? Sotrudnik { get; set; }
    }
}

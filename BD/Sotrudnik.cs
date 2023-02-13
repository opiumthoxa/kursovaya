

namespace Praktica
{
    public class Sotrudnik
    {
        public int Id { get; set; }
        public string? Fio { get; set; }
        public string? Obrazovanie { get; set; }
        public string? Doljnost { get; set; }
        public int? OtdelId { get; set; }
        public int? Age { get; set; }
        public Otdel? Otdel { get; set; }
        public LinkedList<Prikaz> Prikazs { get; set; } = new();
        public LinkedList<Uvolnenie> Uvolnenies { get; set; } = new();
        public LinkedList<Otpusk> Otpusks { get; set; } = new();
        public LinkedList<Komandirovka> Komandirovkas { get; set; } = new();


    }

    
}

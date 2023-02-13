using Praktica;
namespace Praktica
{
    public class Otpusk
    {
        public int Id { get; set; }
        public int? SotrudnikId { get; set; }
        public DateTime? Data { get; set; }
        public int? KolichestvoDney { get; set; }
        public Sotrudnik? Sotrudnik { get; set; }
    }
}



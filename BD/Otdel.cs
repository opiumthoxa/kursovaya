using Praktica;
namespace Praktica
{
    public class Otdel
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Тelephone { get; set; }

        public LinkedList<Sotrudnik> Sotrudnik { get; set; } = new();
    }

}
   
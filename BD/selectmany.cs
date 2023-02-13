/*
using Praktica;

using (ApplicationContext db = new ApplicationContext())
{
    var sotrudniks = db.Otdels.SelectMany(u => u.Sotrudnik,
            (u, l) => new { Name = u.Name, Fio = l.Fio });
    foreach (var p in sotrudniks)
    {
        Console.WriteLine($"{p.Name} - {p.Fio}");
    }
}
*/
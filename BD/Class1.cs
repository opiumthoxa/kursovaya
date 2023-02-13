/*using Microsoft.EntityFrameworkCore;
using Praktica;


Console.WriteLine(" ------------Простая проекция");
using (ApplicationContext db = new ApplicationContext())
{

    var sotrudniks = db.Sotrudniks.ToArray().Select(p => p.Fio);
    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p);
    }


}




Console.WriteLine(" ------------Анонимный объект");
using (ApplicationContext db = new ApplicationContext())
{
    
    var sotrudniks = db.Sotrudniks.ToArray().Select(p => new
    {
        Fio = p.Fio + "(New obj)",
        Age = p.Age * 2
    });
    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p.Fio + " " + p.Age);
    }

}



Console.WriteLine(" ----------Переменные в операторах Linq");
using (ApplicationContext db = new ApplicationContext())
{
    var sotrudniks = from p in db.Sotrudniks.ToArray()
                 let age = p.Age * 2
                 select new
                 {
                     Fio = p.Fio + "(New obj)",
                     Age = age
                 };

    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p.Fio + " " + p.Age);
    }

}


Console.WriteLine(" -----------Декартово произведение");
using (ApplicationContext db = new ApplicationContext())
{
    var sotrudniks = from u in db.Sotrudniks.ToArray()
                 from c in db.Otdels.ToArray()
                 select new
                 {
                     Fio = u.Fio,
                     Otdel = c.Name
                 };
    
    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p.Fio + " " + p.Otdel);
    }

}



Console.WriteLine(" ------------Фильтрация коллекции");
using (ApplicationContext db = new ApplicationContext())
{
   
    var sotrudniks = db.Sotrudniks.ToArray().Where(p => p.Id <= 5).Select(p => p.Fio);
    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p);
    }


}



Console.WriteLine(" ------------Сортировка коллекции");
using (ApplicationContext db = new ApplicationContext())
{

  


var sotrudniks = db.Sotrudniks.ToArray().OrderBy(u => u.Fio);
    foreach (var p in sotrudniks)
    {
       
        Console.WriteLine(p.Fio);
    }

}


Console.WriteLine(" ------------Объединение таблиц");
using (ApplicationContext db = new ApplicationContext())
{

    
    var sotrudniks = db.Sotrudniks.ToArray().Join(db.Otdels.ToArray(), u => u.OtdelId, c => c.Id, (u, c) => new { sotrudnik = u.Fio, otdel = c.Name });
    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p.sotrudnik + " " + p.otdel);
    }

}


Console.WriteLine(" ------------Загрузка связанных данных");

using (ApplicationContext db = new ApplicationContext())
{


    var sotrudniks = db.Sotrudniks.Include(u => u.Otdel).ToArray();



    foreach (var p in sotrudniks)
    {
        Console.WriteLine(p.Fio + " " + p.Otdel?.Name);
    }

}*/


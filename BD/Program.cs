using Microsoft.EntityFrameworkCore;
using Praktica;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {


            /*  using (ApplicationContext db = new ApplicationContext())
              {
                  var sotrudniks = db.Sotrudniks.ToArray();
                  Console.WriteLine("Список объектов");
                  foreach (Sotrudnik u in sotrudniks)
                  {
                      Console.WriteLine(u.Fio + " - " + u.Age);
                  }
              }


              using (ApplicationContext db = new ApplicationContext())
              {
                  Sotrudnik test = new Sotrudnik { Id = 1, Fio = "Хрисанов", Age = 25 };
                  db.Sotrudniks.Add(test);
                  db.SaveChanges();
                  var sotrudniks = db.Sotrudniks.ToArray();
                  Console.WriteLine("Список объектов");
                  foreach (Sotrudnik u in sotrudniks)
                  {
                      Console.WriteLine(u.Fio + " - " + u.Age);
                  }
              }


              using (ApplicationContext db = new ApplicationContext())
              {
                  Sotrudnik? upduser = (from sotrudnik in db.Sotrudniks where sotrudnik.Id == 5 select sotrudnik).First();
                  if (upduser != null)
                  {
                      upduser.Age = upduser.Age * 2;
                      db.SaveChanges();
                  }
                  var users = db.Sotrudniks.ToArray();
                  Console.WriteLine("Список объектов");
                  foreach (Sotrudnik u in users)
                  {
                      Console.WriteLine(u.Fio + " - " + u.Age);
                  }

              }


              using (ApplicationContext db = new ApplicationContext())
              {
                  Sotrudnik? deluser = (from sotrudnik in db.Sotrudniks where sotrudnik.Id == 5 select sotrudnik).First();
                  if (deluser != null)
                  {
                      db.Sotrudniks.Remove(deluser);
                      db.SaveChanges();
                  }
                  var sotrudniks = db.Sotrudniks.ToArray();
                  Console.WriteLine("Список объектов");
                  foreach (Sotrudnik u in sotrudniks)
                  {
                      Console.WriteLine(u.Fio + " - " + u.Age);
                  }

              }

             using (ApplicationContext db = new ApplicationContext())
              {
                  var sotrudniks = db.Sotrudniks.ToArray();

                  var otdel = db.Otdels.Where(c => c.Id ==  6 ).FirstOrDefault();

                  Sotrudnik sotrudnik = new Sotrudnik { Id = 7, Fio = "Заболотин ", Age = 14, Otdel = otdel };


                  db.Sotrudniks.Add(sotrudnik);

                  db.SaveChanges();


         




            

            }*/
            // Запросы

            /* using (ApplicationContext db = new ApplicationContext())
             {

                 var users = from u in db.Otdels.ToArray()
                             join
                              c in db.Sotrudniks.ToArray() on u.Id equals c.Id
                             select new { Otdel = u.Name, Fio = c.Fio };

                 foreach (var p in users)
                 {
                     Console.WriteLine(p.Otdel + " " + p.Fio);
                 }


             }
            */

             using (ApplicationContext db = new ApplicationContext())
            {
                Sotrudnik test = new Sotrudnik { Id = 6, Fio = "Веселов Алексей Васильевич", Obrazovanie = "Высшее", Doljnost = "Старший мененджер", OtdelId = null, Age = 28 };
                db.Sotrudniks.Add(test);
                db.SaveChanges();
                var Sotrudnik = db.Sotrudniks.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Sotrudnik u in Sotrudnik)
                {
                    Console.WriteLine(u.Id + " - " + u.Fio + " - " + u.Doljnost);
                }

            }
            

            /* using (ApplicationContext db = new ApplicationContext())
            {
                Otpusk deluser = (from Otpusk in db.Otpusks where Otpusk.Id == 1 select Otpusk).First();
                if (deluser != null)
                {
                    db.Otpusks.Remove(deluser);
                    db.SaveChanges();
                }
                var otpusks = db.Otpusks.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Otpusk u in otpusks)
                {
                    Console.WriteLine(u.Id);
                }

            }
          */

            /*
            using (ApplicationContext db = new ApplicationContext())
            {
                Komandirovka? upduser = (from Komandirovka in db.Komandirovkas where Komandirovka.Id == 3 select Komandirovka).First();
                if (upduser != null)
                {
                    upduser.SrokVSutkah = upduser.SrokVSutkah * 2;
                    db.SaveChanges();
                }
                var komandirovkas = db.Komandirovkas.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Komandirovka u in komandirovkas)
                {
                    Console.WriteLine(u.Id + " - " + u.SrokVSutkah);
                }



            }
            */
            /*
            using (ApplicationContext db = new ApplicationContext())
            {
                var uvolnenies = from i in db.Uvolnenies.ToArray()
                               where i.Prichina == "Перевод сотрудника"
                               select i;
                foreach (var i in uvolnenies)
                {
                    Console.WriteLine(i.Id + " - " + i.DataUvolnenia);
                }
                Console.WriteLine();
            }
            */




        }
    }
}







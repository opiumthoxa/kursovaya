/*using Praktica;

namespace Practica
{
    internal static class CrudHelpers
    {
        public static void Main(string[] args)
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                Staff test = new Staff { Id = 5, Fio = "Эйнштейн", Age = 25 };
                db.Staffs.Add(test);
                db.SaveChanges();
                var staffs = db.Staffs.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Staff u in staffs)
                {
                    Console.WriteLine(u.Fio + " - " + u.Age);
                }
            }


            using (ApplicationContext db = new ApplicationContext())
            {
                Staff? upduser = (from staff in db.Staffs where staff.Id == 5 select staff).First();
                if (upduser != null)
                {
                    upduser.Age = upduser.Age * 2;
                    db.SaveChanges();
                }
                var users = db.Staffs.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Staff u in users)
                {
                    Console.WriteLine(u.Fio + " - " + u.Age);
                }

            }


            using (ApplicationContext db = new ApplicationContext())
            {
                Staff? deluser = (from staff in db.Staffs where staff.Id == 5 select staff).First();
                if (deluser != null)
                {
                    db.Staffs.Remove(deluser);
                    db.SaveChanges();
                }
                var staffs = db.Staffs.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Staff u in staffs)
                {
                    Console.WriteLine(u.Fio + " - " + u.Age);
                }

            }

        }
    }
}*/
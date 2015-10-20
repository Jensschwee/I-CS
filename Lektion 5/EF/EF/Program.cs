using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            FindETCS();
            AddNewRecord();
            RemoveRecord();
        }

        public static void AddNewRecord()
        {
            using (testEntities contex = new testEntities())
            {
                try
                {
                    contex.Courses.Add(new Courses("Test",5.0, "1.0",DateTime.Now));
                    contex.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }
        }

        public static void RemoveRecord()
        {
            using (testEntities contex = new testEntities())
            {
                try
                {
                    //Define a key for the entity we are looking for.
                    var coursesToDelete = contex.Courses.Where(p => p.Cid == 1);


                    if (coursesToDelete != null)
                    {
                        contex.Courses.RemoveRange(coursesToDelete);
                        contex.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }
        }

        public static void FindETCS()
        {
            using (testEntities contex = new testEntities())
            {
                try
                {
                    //Define a key for the entity we are looking for.
                    var courses = contex.Courses.Where(p => p.ECTS == (decimal) 5.0);

                    PrintCoures(courses );

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }
        }

        private static void PrintCoures(IEnumerable<Courses> coures )
        {
            foreach (Courses c in coures)
            {
                Console.WriteLine(c);
            }
            
        }


    }
}

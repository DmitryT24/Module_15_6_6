using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            //1) 

            return classes.SelectMany(x => x.Students).ToArray();

            //2
            //return (from s in classes
            //        from a in s.Students
            //        select a).ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}

//??? - подробно еще раз посмотреть разницу - ???
//https://learn.microsoft.com/ru-ru/dotnet/csharp/linq/standard-query-operators/projection-operations#select-versus-selectmany


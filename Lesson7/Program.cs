using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Tanks.DAL.WOT;

namespace Lesson7
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Tank> t34 = new List<Tank>();
            List<Tank> pantera = new List<Tank>();
            string name1 = "t34-";
            string name2 = "pantera-";
            for (int i = 0; i < 5; i++)
            {
                t34.Add(new Tank(name1 + (i + 1).ToString()));
                pantera.Add(new Tank(name2 + (i + 1).ToString()));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Бой {0}-ый: \n", i + 1);
                t34[i].getInfo();
                Console.WriteLine("\n----Против----\n");
                pantera[i].getInfo();
                Console.WriteLine("\n---Результат---\n");
                Console.WriteLine("В {0} бою победил : " + (t34[i] * pantera[i]).getNaming() + "\n\n\n", i + 1);
            }


        }
    }
}
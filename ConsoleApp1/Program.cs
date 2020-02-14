using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8
{
    struct Student
    {
        public string surname;
        public string inizialy;
        public int group;
        public string uspevaemost;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {surname} Inizialy:{inizialy} Num of group:{group} Uspevaemost:{uspevaemost}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Potter;
            Potter.surname = " Potter";
            Potter.inizialy = "J.P";
            Potter.group = 2;
            Potter.uspevaemost = "отлично";
            double[] a = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(a.Average());
            Potter.DisplayInfo();

            Console.ReadKey();
        }
    }
}

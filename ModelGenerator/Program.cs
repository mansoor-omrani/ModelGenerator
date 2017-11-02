using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mg = new DefaultModelGenerator();

            mg.Load(@"e:\temp\model.json");
            mg.Generate(@"e:\temp");

            System.Console.WriteLine("done");
            System.Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            int myVarMin = int.MinValue;

            int myVarMax = int.MaxValue;

            int charMin = char.MinValue;

            int charMax = char.MaxValue;

            float floatMin = float.MinValue;

            float floatMax = float.MaxValue;

            Console.WriteLine("\n min value int = {0} max value int = {1} \n min value char = {2} max value char = {3} \n min value float = {4} max value float = {5}",myVarMin, myVarMax, charMin, charMax, floatMin, floatMax);
            Console.ReadKey();

            char myChar = 'M';
            int myConvert = 'M';

            

            char Con = Convert.ToChar(77);

            Console.WriteLine("this character {0} this convert = {1} and reconvert = {2}", myChar, myConvert, Con);

            Console.ReadKey();
        }
    }
}

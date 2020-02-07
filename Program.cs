using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Number_One number_One = new Number_One();
            List<string> words = new List<string> {"the","bike","this","it","tenth","mathematics"};
            List<string> THwords = words.FindAll(w => w.Contains("th"));
            foreach (var word in THwords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}

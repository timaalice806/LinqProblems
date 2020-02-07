using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Number_One
    {
        //MEMBER VARIABLES//
        public List<string> words = new List<string>() {"the","bike","this","it","tenth","mathematics"};

        //MEMBER METHODS//
        public static void GetTH()
        {
            List<string> words = new List<string>() {"the","bike","this","it","tenth","mathematics"};
            var THwords = words.FindAll(w => w.Contains("th"));
            foreach (var word in THwords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        } 
    }
}

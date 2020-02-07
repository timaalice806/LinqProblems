using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Number_Two 
    {
        //MEMBER VARIABLES
        public List<string> names = new List<string>() {"Mike", "Brad", "Nevin", "Ian", "Mike"};

        public static void RemoveDuplicate()
        {
            List<string> names = new List<string>() {"Mike","Brad","Nevin","Ian","Mike"};
            var noCopynames = names.Distinct();
            foreach (var name in noCopynames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}

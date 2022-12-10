using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoProblems
{
    public class DemoClass
    {
        public void DictionaryDemo()
        {
            Console.WriteLine("\n**********Dictionary PROGRAM **********\n");

            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            objDictionary.Add(1, "SANJEEV");
            objDictionary.Add(2, "MAHESH");
            objDictionary.Add(3, "PIYUSH");
            objDictionary.Add(4, "RAM");
            objDictionary.Add(5, "RAHUL");



            Console.WriteLine("\nAccess value using key(key=1): " + objDictionary[1]);

            Console.WriteLine("\nIterating Dictionary: ");
            foreach (var element in objDictionary)
            {
                Console.WriteLine($"Key = {element.Key} , Value = {element.Value}");
            }
        }
    }
}

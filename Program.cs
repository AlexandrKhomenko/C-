using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 3, 1, 5, 4, 6, 4 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    dict.Remove(arr[i]);
                    dict.Add(arr[i], i);
            }

            var b = dict.Keys;
            foreach (int a in b)
            Console.Write(a + " ");
            Console.ReadKey();
        }
    }
}

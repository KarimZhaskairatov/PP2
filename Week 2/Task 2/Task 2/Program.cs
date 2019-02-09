using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool prime(int n) // function which will check prime number 
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\HP\Desktop\PP2\Week 2\Task 2\Reader.txt"); // object which will read the text 
            StreamWriter writer = new StreamWriter(@"C:\Users\HP\Desktop\PP2\Week 2\Task 2\Writer.txt"); // object which will write to the file 
            string n = reader.ReadLine(); // reads to string 
            string[] a = n.Split(' '); // crating an array and split string n
            foreach (string s in a)
            {
                if (prime(int.Parse(s)))
                    writer.Write(s + " ");
            }
            reader.Close();
            writer.Close();
        }
    }
}

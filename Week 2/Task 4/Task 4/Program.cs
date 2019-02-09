using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\HP\Desktop\PP2\Week 2\Task 4\1.txt");
            writer.Write("karim");
            writer.Close();
            File.Copy(@"C:\Users\HP\Desktop\PP2\Week 2\Task 4\1.txt", @"C:\Users\HP\Desktop\PP2\Week 2\Task 4\2.txt");
            File.Delete(@"C:\Users\HP\Desktop\PP2\Week 2\Task 4\1.txt");
        }
    }
}

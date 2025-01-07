using System;
using System.IO;
using System.Text;

namespace _04_FastAddition {
    class Program {
        static void Main(string[] args) {
            int numOfTimes = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < numOfTimes; i++) {
                using (StringReader reader = new StringReader(Console.ReadLine())) {
                    string[] text = reader.ReadLine().Split(' ');
                    int a = int.Parse(text[0]);
                    int b = int.Parse(text[1]);
                    builder.Append((a + b) + "\n");
                }
            }
            Console.WriteLine(builder);
        }
    }
}
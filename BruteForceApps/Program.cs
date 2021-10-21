using System;

namespace BruteForceApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write to text: ");
            string text = Console.ReadLine();

            FirstApp firstApp = new FirstApp();
            //firstApp.Directory = "";
            //firstApp.FileName = "şifreler";
            firstApp.Run(text);

            SecondApp secondApp = new SecondApp();
            //secondApp.Directory = "ANA DİZİN";
            //secondApp.FileName = "şifreler2";
            secondApp.Run();
        }
    }
}

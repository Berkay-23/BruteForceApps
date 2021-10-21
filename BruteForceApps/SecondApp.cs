using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceApps
{
    public class SecondApp
    {
        public string Directory { get; set; }
        public string FileName { get; set; }

        public SecondApp(string Directory, string FileName)
        {
            this.Directory = Directory;
            this.FileName = FileName;
        }

        public SecondApp()
        {
            this.Directory = @"C:\Users\iredc\Desktop\datas";
            this.FileName = "şifreler2";
        }

        public void Run()
        {
            List<byte> numbers = new List<byte>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<string> datas = new List<string>();

            string data = String.Empty;

            foreach (byte digit1 in numbers)
            {
                foreach (byte digit2 in numbers)
                {
                    foreach (byte digit3 in numbers)
                    {
                        foreach (byte digit4 in numbers)
                        {
                            data += digit1.ToString();
                            data += digit2.ToString();
                            data += digit3.ToString();
                            data += digit4.ToString();
                            datas.Add(data);
                            data = String.Empty;
                        }
                    }
                }
            }

            CreateTXT(Directory, FileName);
            WriteToPasswordTXT($@"{Directory}\{FileName}.txt", datas);
        }

        private void CreateTXT(string directory, string fileName)
        {
            FileStream fileStream = File.Create($@"{directory}\{fileName}.txt");
            fileStream.Close();
        }

        private void WriteToPasswordTXT(string directory, List<string> datas)
        {
            File.WriteAllLines(directory, datas);
        }
    }
}

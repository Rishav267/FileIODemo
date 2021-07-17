using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //collect name from user and store into file
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("C:\\Users\\risha\\OneDrive\\Documents\\names.txt");
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                    reader.Close();
                }

                string allData = reader.ReadToEnd();
                Console.WriteLine(allData);

                File.Delete("");
                FileInfo info = new FileInfo("C:\\Users\\risha\\OneDrive\\Documents\\names.txt");
                Console.WriteLine(info.CreationTime);
                Console.WriteLine(info.Length);
                Directory.GetFiles("C....");
                foreach (var f in Directory.GetFiles("C...."))
                {
                    Console.WriteLine(f);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            //Write();

        }

        private static void Write()
        {
            string name;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            StreamWriter writer = new StreamWriter("C:\\Users\\risha\\OneDrive\\Documents\\names.txt"); // if file name does not exist , it will be created by OS
            writer.WriteLine(name);
            writer.Close();
        }
    }
}

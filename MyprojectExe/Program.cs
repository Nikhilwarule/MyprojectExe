using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace MyprojectExe
{
    public class Program   //creation of folder and file
    {
        static void CreateFolder()
        {
            string path = @"D:\My c#project\TestFolder";

            if (Directory.Exists(path))
            {
                Console.WriteLine("folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("folder is created");
            }
        }
         static void CreatedFile()
         {
             string path = @"D:\My c#project\TestFolder\TestFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File already exist");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created");
            }
         }
        static void Main(string[] args)
        {
            CreateFolder();
            CreatedFile();

        }
 
    }
    class Program3
    {
        static void CreateFolder()
        {
            string path = @"D:\My c#project\TestFolder1";
            DirectoryInfo d = new DirectoryInfo(path);
            if (d.Exists)
            {
                Console.WriteLine("folder is already created");
            }
            else
            {
                d.Create();
                Console.WriteLine("folder is created");

            }

        }
        static void createFile()
        {
            string path = @"D:\My c#project\TestFolder\TestFile.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine("File already exits");

            }
            else
            {
                f.Create();
                Console.WriteLine("File created");
            }
        }
        static void Main(string[] args)
        {
            CreateFolder();
            createFile();
        }
    }
    public class Dept
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
   /* public class Program3

    {
         static void WriteToFile(Dept dept)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(dept.id);
                bw.Write(dept.Name);
                bw.Write(dept.Location);
                bw.Close();
                fs.Close();
                Console.WriteLine("Data added to file");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void ReadFormFile()
        {
            try
            {
                FileStream fs= new FileStream(@"D:\My c#project\TestFolder\TestFile", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
                br.Close();
                fs.Close();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void Main(string[] args)
        {
            Dept dept =new Dept {id =1,Name ="HR",Location="Pune"};
            WriteToFile(dept);
            //ReadFormFile();

        }
    }*/
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int fees { get; set; }
    }


    class filebinerydemo   //Assignment Pro1
    {
        static void WriteToFile(Course cs)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\TestFile2", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(cs.ID);
                bw.Write(cs.Name);
                bw.Write(cs.fees);
                bw.Close();
                fs.Close();
                Console.WriteLine("data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\TestFile2", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        static void Main(string[] args)
        {
            Course cs = new Course { ID = 101, Name = "Amol", fees = 25000 };
            WriteToFile(cs);
            ReadFromFile();

        }
    }
    class streamw //Assignment Pro2
    {
        static void WriteToFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\TestFile.txt2", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                //  sw.WriteLine("sample text in file");
                string str = Console.ReadLine();
                sw.WriteLine(str);

                sw.Close();
                fs.Close();
                Console.WriteLine("done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder\TestFile.txt2", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void Main(string[] args)
        {
            WriteToFileUsingStream();
            ReadFromFileUsingStream();
        }
    }
}
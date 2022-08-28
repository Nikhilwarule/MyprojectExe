using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;

namespace MyprojectExe
{
    [Serializable]

    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public int pPrice { get; set; }
    }
    internal class Assign2
    {
        static void BinerySerializationWrite(Products pt)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\BinaryFile1.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, pt);
                Console.WriteLine("binery data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void BinerySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\BinaryFile1.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Products pt = (Products)bf.Deserialize(fs);
                Console.WriteLine(pt.pId);
                Console.WriteLine(pt.pName);
                Console.WriteLine(pt.pPrice);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            static void XmlSerializationWrite(Products pt)
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\XmlFile1.xml", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(Products));
                    xs.Serialize(fs, pt);
                    Console.WriteLine("Xml data added");
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            static void XmlSerializationRead()
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\XmlFile1.xml", FileMode.Open, FileAccess.Read);
                    XmlSerializer xs = new XmlSerializer(typeof(Products));
                    Products pt = (Products)xs.Deserialize(fs);
                    Console.WriteLine(pt.pId);
                    Console.WriteLine(pt.pName);
                    Console.WriteLine(pt.pPrice);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        static void JsonSerializationWrite(Products pt)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\JsonFile1.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Products>(fs, pt);
                Console.WriteLine("json  data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\JsonFile1.json", FileMode.Open, FileAccess.Read);
                Products pt = JsonSerializer.Deserialize<Products>(fs);
                Console.WriteLine(pt.pId);
                Console.WriteLine(pt.pName);
                Console.WriteLine(pt.pPrice);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void SoapSerializationWrite(Products pt)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\SoapFile1.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, pt);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\My c#project\TestFolder1\SoapFile1.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Products pt = (Products)sf.Deserialize(fs);
                Console.WriteLine(pt.pId);
                Console.WriteLine(pt.pName);
                Console.WriteLine(pt.pPrice);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        static void Main(string[] args)
        {
            Products ptd = new Products { pId = 100, pName = "bat", pPrice = 500 };
            //  BinerySerializationWrite(ptd);
            // BinerySerializationRead();
            // XmlSerializationWrite(ptd);
            //  XmlSerializationRead();
            // JsonSerializationWrite(ptd);
            //JsonSerializationRead();
              //SoapSerializationWrite(ptd);
            SoapSerializationRead();
        }
    }

}

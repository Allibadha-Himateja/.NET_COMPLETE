using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
namespace Mynamespace
{
    [Serializable]  // Required for binary serialization
    public class Product
    {
        public int pid;
        public string name;  // lowercase 'string' in C#
        public double fee;

        public Product() { }  // Default constructor needed for deserialization

        public Product(int pid, string name, double fee)
        {
            this.pid = pid;
            this.name = name;
            this.fee = fee;
        }

        public override string ToString()
        {
            return $"PID: {pid}, Name: {name}, Fee: {fee}";
        }
    }

    public class StreamsDemo
    {
        public static void Main()
        {
            //System.Console.WriteLine("Hello Coder");
            // we have to text the streams 
            // for that we should text streams for retriving the data from the file

            //System.IO.FileStream fs = System.IO.File.OpenRead("streamsintro.txt");
            //byte[] b = new byte[fs.Length];
            //fs.Read(b, 0, b.Length);
            //string str=ASCIIEncoding.ASCII.GetString(b);
            //Console.WriteLine(str);

            // Create a proper object instead of anonymous class
            Product o = new Product(1001, "dell", 2003.0);

            // Serialize the object
            FileStream fs = new FileStream("result.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, o);
            fs.Close();

            // Deserialize the object
            FileStream rs = new FileStream("result.txt", FileMode.Open, FileAccess.Read);
            Product m = (Product)bf.Deserialize(rs);
            rs.Close();

            Console.WriteLine(m);
        }
    }
}
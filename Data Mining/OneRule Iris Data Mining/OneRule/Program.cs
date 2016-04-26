using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OneRule
{
    struct Node
    {
        public double width1;
        public double height1;
        public double width2;
        public double height2;
        public String class_;

        public String toString()
        {
            return String.Format(" {0}, {1}, {2}, {3}  -  {4}", width1, height1, width2, height2, class_);
        }

       
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string setosa = "Iris-setosa";
            var reader = new StreamReader(File.OpenRead(@"E:\Projects\C#\Console\OneRule\OneRule\Resources\iris.data"));
            List<Node> listIrisData = new List<Node>();
            
                
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                Node node = new Node();
                node.width1 = Convert.ToDouble(values[0]);
                node.height1 = Convert.ToDouble(values[1]);
                node.width2 = Convert.ToDouble(values[2]);
                node.height2 = Convert.ToDouble(values[3]);
                node.class_ = values[4];
                
                listIrisData.Add(node);
                listIrisData.Sort((s1,s2)=> s1.height1.CompareTo(s2.height1));
                listIrisData.Sort((s3, s4) => s3.height2.CompareTo(s4.height2));
                

            }

            foreach (Node value in listIrisData)
            {
                Console.WriteLine(value.toString());
                if (value.Equals(setosa))
                    Console.WriteLine("Setosa;;;;;;;;;;;;");
            }
                

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

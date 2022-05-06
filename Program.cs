using System;
using System.IO;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace ReadtextFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string res, res_;
            res = "string";
            res_ ="string";
            Console.WriteLine("Insert text to be replaced.");
            res = Console.ReadLine();
            Console.WriteLine("Insert replacement text.");
            res_ = Console.ReadLine();
            Console.WriteLine("Insert folder path.");
            var P= Console.ReadLine();
            string path = P;
            try
            {

                foreach (string file in Directory.GetFiles(path))
                {

                    string text = File.ReadAllText(file);
                    //woslebtcfs004  wosnpntcfs001
                    text = text.Replace(res, res_);
                    File.WriteAllText(file, text);

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
         
            
            
         

         
        }


       

    }
}

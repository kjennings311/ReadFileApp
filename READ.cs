using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadtextFile
{
    class READ
    {

        /*


        List<int> list_ = new List<int>() {

            23602,
            23602,
            23666,
            92571,
            31322,
            23666,
            38843,
            95203,
            22630,
            28203,
            76657,
            35968,
            23228,
            23602,
            91752,
            92571,
            91748,
            33843,
            99354,
            50703,
            23666,
            23666,
            45822,
            12051,
            23602,
            78754,
            99354,
            23666,
            91766,
            95203,
            22630,
            76657,
            35968,
            91752,
            33843,
            50703,
            45822,
            12051,
            23602,
            98001,
            94577,
            45822,
            74116,
            28269,
            22630,
            38843,
            21227,
            23602,
            23602,
            95203,
            23666,
            23666,
            23666,
            23666,
            23666,
            76657


            };


        List<int> list = new List<int>();

        list = list_.Distinct().ToList();


        string numb = "";
        int counter = 0;
        string line;
        string path = @"C:\Users\ABE4042\Downloads\Miles files\gaz2016zcta5distancemiles - Copy.csv";
            // Read the file and display it line by line.  
            //  System.IO.StreamReader file =
            //  new System.IO.StreamReader(path);

            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader file = new StreamReader(bs))
            {

                while ((line = file.ReadLine()) != null)
                {
                    //System.Console.WriteLine(line);
                    var res = line.Substring(0, 7);
    res = new string ((from c in res
                       where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                                      select c
            ).ToArray());

                    //Console.WriteLine(res);
                    //    Console.ReadLine();
                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        if (list.ElementAt(i).ToString() == res)
                        {
                            File.AppendAllText(@"c:\Users\ABE4042\Downloads\Miles files\Match4.txt", line + Environment.NewLine);
                        }
                    }

                    counter++;
                }
            }


            System.Console.WriteLine("There were {0} lines.", counter);
// Suspend the screen.  
System.Console.ReadLine();
        */
    }
}

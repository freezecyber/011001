using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01011010
{
    class Program
    {
        private static string hdgf;

        static void Main(string[] args)
        {

            hdgf = File.ReadAllText("pg.tx");

            Thread lhfeg = new Thread(new ThreadStart(pg));
            lhfeg.Start();
            Console.WriteLine("pg.tx            :         pg.tx          : to interval timer");
          

            //loop to display string pattern
            //you can change the no. of times the loop execute

        }
        private static void pg()
        {

            string str = " ";
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                //create new string pattern
                if (i % 2 == 0)
                {
                    str = "";
                    for (int j = 0; j < 79; j++)
                    {
                        int n = rand.Next(5);
                        if (n < 2)
                        {
                            str += n.ToString();
                        }
                        else
                        {
                            str += " ";
                        }
                    }
                }

                //print str pattern
                Console.WriteLine(str);
            }
            Thread.Sleep(int.Parse(hdgf));
            Thread lhtfe = new Thread(pg);
            lhtfe.Start();
        }


    }
}

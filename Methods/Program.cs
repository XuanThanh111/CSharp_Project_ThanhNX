using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
            Console.ReadKey();
        }
        void run()
        {
            double dailyRate = readDouble("Enter your daily rate:");
            int noOfday = readInt("Enter the number of day:");
            WriteFree(CaculatorFree(dailyRate, noOfday));
        }

        private void WriteFree(double p)
        {
            try
            {
                Console.WriteLine("The consultant’s fee is: {0}", p * 1.1);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private double CaculatorFree(double dailyRate, int noOfday)
        {
            return dailyRate * noOfday;
        }

        private int readInt(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string p)
        {
            double _readDouble= 0.0;
            Boolean test = false;
            try
            {
                while (!test)
                {
                    Console.Write(p);
                    string line = Console.ReadLine();
                    _readDouble= int.Parse(line);
                    goto exit;
                }
            } catch(Exception ex)
            {
              test = false;
              Console.WriteLine(ex.GetType().ToString());   
            }
            exit:
            return _readDouble;
            }
        }

    }



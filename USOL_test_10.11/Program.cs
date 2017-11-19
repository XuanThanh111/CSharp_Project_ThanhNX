using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USOL_test_10._11
{
    class Program
    {      
        //Tinh tong cac so trong day chia het cho 3,4 va khong chi het cho 5
       public static int exam1(int[] array)
        {
            int S = 0;
            for (int i=0; i<10; i++)
            {
                if (   array[i] % 3 == 0 
                    && array[i]%4==0
                    && array[i] % 5 != 0)
                {
                    S =S+array[i];
                }
            }
            return S;
        }
        
        public static int exam2(int[] array)
        {
            int min = Int32.MaxValue;
            for(int i=0; i < 10; i++)
            {             
                   if(array[i] < min)
                {
                    min = array[i];
                }
                
            }
            return min;
        }
        //ham xac dinh so nguyen to
        public static Boolean isPrimeNumber(int n)

        {

            if (n < 2) return false;

            for (int i = 2; i < n; i++)

                if (n % i == 0) return false;

            return true;

        }
        public static String exam3(int[] array)
        {
            String tmp = "";
            
            for(int i=0; i<10; i++)
            {
                if (isPrimeNumber(array[i]))
                {
                    tmp += array[i] + " ";
                }
                else if (tmp == null)
                {
                    Console.WriteLine("Trong mang khong co so nguyen to");
                }
            }
            return tmp; 
        }

        static void Main(string[] args)
        {
            int[] ArrSo = new int[10];
            // int[]ArrSO={1,2,2,3,3,2,3,34,2,23};
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ArrSo[{0}]:",i );
                ArrSo[i] = int.Parse(Console.ReadLine());               
            }
            Console.WriteLine("Day vua nhap la:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ArrSo[i]+"  ");
            }
            Console.WriteLine(" ");       
            Console.WriteLine("Tong la:" + exam1(ArrSo));

            Console.WriteLine("So nho nhat trong day la: " + exam2(ArrSo));

            Console.WriteLine("SO nguyen to la: " + exam3(ArrSo));

            Console.ReadKey();
        }

    }
}

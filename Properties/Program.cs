using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Property: thuộc tính của 1 đối tượng
//C# sử dụng property để thao tác với các dữ liệu=> bảo vệ dữ liệu 1 cách tự nhiên<Tính bao đóng>
/*************************************************/
//CÚ PHÁP
//kiểu_trả_về biến;
//chỉ_định_từ_truy_xuất kiểu_trả_về tên_property
//{
//    set { biến = value; }
//    get { return biến; }
//}
/***********************************************/

namespace Properties
{
    class Student
    {
        private int ID;
        private String UserName;

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                if (ID > 0)
                {
                    ID = value;
                }
                else ID = 0;
            }
        }

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Student student = new Student();
            do
            {
                Console.WriteLine("Id sinh vien: ");
                student.ID1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("UserName: ");
                student.UserName1 = Console.ReadLine();

                Console.WriteLine(student.UserName1 + "has ID is " + student.ID1);
            } while (student.ID1==-1);

                        Console.ReadKey();
        }
    }
}

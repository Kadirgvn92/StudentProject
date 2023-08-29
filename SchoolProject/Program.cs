using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            SchoolInfo schoolInfo = new SchoolInfo(12029, "Kadir", "GÜVEN", 70, 50, 85, "Bahçeşehir Unıversity");
            schoolInfo.menu();
            bool cycle = true;

            while (cycle) 
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                schoolInfo.menu();
                switch (choose)
                {
                    case 1:
                        schoolInfo.getStudentInfo();
                        break;
                    case 2:
                        schoolInfo.getStudentOverall();
                        break;
                    case 3:
                        schoolInfo.getSchoolInfo();
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yaptınız..");
                        cycle = false;
                        break;
                    default:
                        Console.WriteLine("You have made an invalid transaction..");
                        break;
                }
            }
            
        }
    }
}

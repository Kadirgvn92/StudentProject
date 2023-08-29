using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class SchoolInfo
    {
        private int studentId;
        private String studentName;
        private String studentSurname;
        private int studentExam_1;
        private int studentExam_2;
        private int studentFinal;
        private int studentOverall;
        private String schoolName;

        public SchoolInfo(int _studentId, String _studentName, String _studentSurname, int _studentExam_1, int _studentExam_2,
                          int _studentFinal, String _schoolName)
        { 
            studentExam_1 = _studentExam_1; 
            studentExam_2 = _studentExam_2;
            studentFinal = _studentFinal;
            schoolName = _schoolName;
            studentName = _studentName;
            studentId = _studentId;
            studentSurname = _studentSurname;   
        }

        public void getStudentInfo() 
        { 
            Console.WriteLine("Student Information : " + studentId + " " + studentName + " " + studentSurname);
        }

        public void getStudentOverall() 
        { 
            studentOverall = (studentExam_1 + studentExam_2 + studentFinal) / 3;

            Console.WriteLine(" Student Note Overall :" + studentOverall);
        }

        public void getSchoolInfo() 
        {
            Console.WriteLine("School Name : " + schoolName);
        }

        public void menu() 
        {
            Console.WriteLine(" -- Welcome Bahçeşehir Unıversıty -- ");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Get Student Information ");
            Console.WriteLine("2 - Get Student Note Overall ");
            Console.WriteLine("3 - Get Scholl Information ");
            Console.WriteLine("4 - Exit");
        }


    }
}

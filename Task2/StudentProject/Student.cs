using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public struct Student
    {
        public string studentName;
        public string nameOfExam;
        public DateTime dateOfExam;
        public int examGrade;

        public Student(string studentName, string examName, DateTime examDate, int examMark)
        {
            if( studentName != null && studentName != "" && examName != null && examName != "" && examDate <= DateTime.Now && examDate >= DateTime.MinValue && 
                examMark <= 100 && examMark >= 0)
            {
                this.studentName = studentName;
                nameOfExam = examName;
                dateOfExam = examDate;
                examGrade = examMark;
            }
            else throw new ArgumentException("Incorrect data");
        }
           
    }
}

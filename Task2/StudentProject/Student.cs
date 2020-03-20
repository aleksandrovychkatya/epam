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
            this.studentName = studentName;
            this.nameOfExam = examName;
            this.dateOfExam = examDate;
            this.examGrade = examMark;
        }
    }
}

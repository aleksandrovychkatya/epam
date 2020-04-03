using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StudentProject;

namespace Tests
{
    public class UnitTestsForStudentProject
    {

        [Fact]
        public void Constructor_AllParametersCorrect_CreateNewStudentStructureWithData()
        {
            DateTime date = new DateTime(20, 03, 20);
            Student student = new Student("Petro", "Math", date, 77 );

            Assert.Equal(77, student.examGrade);
        }

        [Fact]
        public void Constructor_IncorrectNameOfStudent_ArgumentException()
        {
            DateTime date = new DateTime(20, 03, 20);
            

            Assert.Throws<ArgumentException>(() => { Student student = new Student("", "Math", date, 77); });
        }

        [Fact]
        public void Constructor_IncorrectNameOfExam_ArgumentException()
        {
            DateTime date = new DateTime(20, 03, 20);


            Assert.Throws<ArgumentException>(() => { Student student = new Student("Petro", null, date, 77); });
        }

        [Fact]
        public void Constructor_IncorrectDateOfExam_ArgumentException()
        {
            DateTime date = new DateTime(20, 04, 20);


            Assert.Throws<ArgumentException>(() => { Student student = new Student("", "Math", date, 77); });
        }

        [Fact]
        public void Constructor_IncorrectExamGrade_ArgumentException()
        {
            DateTime date = new DateTime(20, 03, 20);


            Assert.Throws<ArgumentException>(() => { Student student = new Student("", "Math", date, 115); });
        }
    }
}

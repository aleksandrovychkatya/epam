using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProject;
using BinaryTreeProject;
using Array;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(20, 02, 10);
            Student st1 = new Student("Bob", "Math", dateTime, 85);
            Student st2 = new Student("nfv", "Math", dateTime, 46);
            Student st3 = new Student("wvrv", "Math", dateTime, 22);
            Student st4 = new Student("esvrav", "Math", dateTime, 100);
            Student st5 = new Student("vsvvr", "Math", dateTime, 95);
            Student st6 = new Student(" dfr", "Math", dateTime, 88);
            Student st7 = new Student("svfver", "Math", dateTime, 98);
            Student st8 = new Student("dsgrew", "Math", dateTime, 48);
            Student st9 = new Student("vsrv", "Math", dateTime, 51);
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(st1.examGrade);
            testTree.Add(st2.examGrade);
            testTree.Add(st3.examGrade);
            testTree.Add(st4.examGrade);
            testTree.Add(st5.examGrade);
            testTree.Add(st8.examGrade);
            testTree.Add(st6.examGrade);
            testTree.Add(st7.examGrade);
            testTree.Add(st9.examGrade);
            foreach (int btn in testTree)
            {
                Console.WriteLine(btn);
            }
            testTree.Remove(85);

            foreach (int btn in testTree)
            {
                Console.WriteLine(btn);
            }


            /*
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(8);
            testTree.Add(6);
            testTree.Add(15);
            testTree.Add(11);
            testTree.Add(12);
            testTree.Add(14);
            testTree.Add(13);
            testTree.Add(7);
            testTree.Add(3);
            testTree.Add(10);
            testTree.Add(20);
            foreach(int btn in testTree)
            {
                Console.WriteLine(btn);
            }

            testTree.Remove(11);

            foreach (int btn in testTree)
            {
                Console.WriteLine(btn);
            }*/





            Console.Read();
        }
    }
}

using AssignmentBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBase
{
    public class AllSolution
    {
        #region CountEvenOdd
        //Question 1 Count EvenOdd
        public static void CountEvenOdd()
        {
            int[] numbers = { 50, 65, 56, 71, 81 };
            int evenCount, oddCount;
            evenCount = oddCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                } else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Finds Number of Even and Odd Numbers in Array");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Even Numbers Count: " + evenCount);
            Console.WriteLine("Odd Numbers Count: " + oddCount);
            Console.ReadLine();
        }
    
    #endregion

    #region Boxing and Unboxing Q2
    ////The process of converting value type to refernce type variable called boxing.
    ////The process of converting reference type varaible to value type called unboxing.
    public static void Boxing()
    {
        int num = 2020;

        // boxing
        object obj = num;

        // value of num to be change
        num = 100;

        System.Console.WriteLine
        ("Value - type value of num is : {0}", num);
        System.Console.WriteLine
        ("Object - type value of obj is : {0}", obj);
    }
    public static void UnBoxing()
    {
        // assigned int value
        // 23 to num
        int num = 23;

        // boxing
        object obj = num;

        // unboxing
        int i = (int)obj;

        // Display result
        Console.WriteLine("Value of ob object is : " + obj);
        Console.WriteLine("Value of i is : " + i);
        }
        //#endregion

        #region Q3 Largest Value
        public static void LargestValue()
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }

        #endregion

        #region Q4 OddNumber
        public static void OddNumber()
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        #endregion

        #region Q5 shortstring
        public static void shortstring()

        {
            List<string> names = new List<string>();
            names.Add("Delhi");
            names.Add("Mumbai,");
            names.Add("Kolkata,");
            names.Add("Chennai");

            names.Sort();
            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
        #endregion

        #region Q6 method overloading

        //It is the common way of implementing polymorphism, it is the ability to redefine a function in more than aonr form.
        public static void MethodOverloading()
        { }
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //overlaoded method
        public static double Addition(double a, double b, double c)
        {
            return a + b + c;
        }



        #endregion

        #region Q7 Dictionary
        public static void GenericDictionary()
        {
            Dictionary<int, string> My_dict1 =
                      new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1, "Rohit");
            My_dict1.Add(2, "Rishabh");
            My_dict1.Add(3, "Virat");
            My_dict1.Add(4, "Iyer");
            My_dict1.Add(5, "SKY");
            My_dict1.Add(6, "DK");
            My_dict1.Add(7, "Jadeja");
            My_dict1.Add(8, "Bhuvneshwar");
            My_dict1.Add(9, "Bumrah");
            My_dict1.Add(10, "Shami");
            My_dict1.Add(11, "Chahal");


            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();
        }

        #endregion

        #region Q8 TeenagerStudent
          public static void Student()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Akash", StudentAge = 23} ,
                new Student() { StudentID = 2, StudentName = "Suman",  StudentAge = 21 } ,
                new Student() { StudentID = 3, StudentName = "Vick",  StudentAge = 18 } ,
                new Student() { StudentID = 4, StudentName = "Hemant" , StudentAge = 20} ,
                new Student() { StudentID = 5, StudentName = "Anirudh" , StudentAge = 15 }
            };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.StudentAge >13 && s.StudentAge < 19
                                  select s;
            Console.WriteLine("Teen age Students:");

            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName, std.StudentID, std.StudentAge);
            }
        }
    }



    public class Student
    {

        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public int StudentAge { get; set; }
    }

    #endregion

    #region Q9 interface
    public class Computation : IComputation
    {


        public int Add()
        {
            int x, y;
            Console.WriteLine("Enter the First number for add");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second  number for add");
            y = Convert.ToInt32(Console.ReadLine());
            return x + y;
        }
        public int Multiplication()
        {
            int x, y;
            Console.WriteLine("Enter the First number for multiply");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second  number for multiply");
            y = Convert.ToInt32(Console.ReadLine());
            return x * y;
        }
        


    }
   
    #endregion

    

}



#endregion
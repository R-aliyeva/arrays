using System;
using System.Diagnostics.CodeAnalysis;

namespace prep_task
{
    public class Student
    {
        public string name { get; set; }
        public int grade { get; set; }
        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }
    public static class StringArrayHelper
    {
        public static void Add(ref string[] arr, string value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
        }
        public static void Add(ref string[] arr, int value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value.ToString();
        }

        public static void GetAvaragegrade(string[] arr)
        {
            int sum = 0;
            int st=arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                int gr = Convert.ToInt32(arr[i]);
                sum += gr;
            }
            Console.WriteLine(sum/st);


        }
        public static void GetHighestGrade(string[] arr)
        {
            

            Console.WriteLine(arr.Max());


        }
        public static void GetLowestGrade(string[] arr)
        {


            Console.WriteLine(arr.Min());


        }

     
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter strudent count");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] arr1 = new string[] {};
            string[] arr = new string[] { };
           
            for (int i = 0;i < count;i++)
            {
                Console.WriteLine("enter student name");
                string names = Console.ReadLine();
                Console.WriteLine("enter student grade");
                int grades = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(names, grades);
                StringArrayHelper.Add(ref arr1, student.name);
                StringArrayHelper.Add(ref arr, student.grade);

            }
           StringArrayHelper.GetHighestGrade(arr);
           StringArrayHelper.GetLowestGrade(arr);
            StringArrayHelper.GetAvaragegrade(arr);


           
        }
    }







}
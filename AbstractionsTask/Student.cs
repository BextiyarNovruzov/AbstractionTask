using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask
{
    internal abstract class Student:User
    {
        private static int IdCounter =0;
        private int Id { get; }
        public string FullName
        { get 
            {
                return FullName;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Student name daxil etmek mutleqdir.");
                }
                else {FullName = value; } 

            } 
        }

        public string Point 
        {
            get
            {
                return Point;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Student ucun Point daxil etmek mutleqdir.");
                }
                else { Point = value; }

            }
        }

        public Student(int ID ,string FullName, string Point, string Email, string Password):base(ID,FullName,Email,Password)
        {
            Id = ++IdCounter; // ID avtomatik artan sayğacla təyin edilir
            this.FullName = FullName;
            this.Point = Point;
        }

        //- StudentInfo() - Student-in bütün məlumatlarını ekrana console-a yazdırır
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {FullName}, Point: {Point}");
        }
    }
}

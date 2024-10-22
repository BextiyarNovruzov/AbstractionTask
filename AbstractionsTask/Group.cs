using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask
{
    internal class Group:Student
    {

        public int GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return StudentLimit;
            }
            set
            {
                if (value > 5 && value < 18)
                {
                    value = StudentLimit;
                }
                else
                {
                    Console.WriteLine("Telebe sayi limiti kecdi.");
                }
            }
        }

        private Student[] Students;

        public Group(int Id,int groupNo, int studentLimit,string FullName,string Point,string Email,string Password):base(Id,FullName,Point,Email,Password) 
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[0];
        }

        //- CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə true/false dəyərləri qaytarır.
        //  Şərtlər: 2 böyük hərf əvvəldə və 3 rəqəmdən ibarət olmalıdır
        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5 &&
                char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) &&
                char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
            {
                return true;
            }
            return false;
        }
        //- AddStudent() - parametr olaraq Student obyekti qəbul edir və gələn student obyektini Group class-ında olan Students arrayinə əlavə edir
        //əgər arrayin uzuluğu StudentLimit-i keçirsə əlavə etməməlidi.
        public void AddStudent(Student student)
        {
            if (Students.Length >= StudentLimit)
            {
                Console.WriteLine("Qrup doludur, daha cox telebe elave edilə bilmez.");
                return;
            }
           
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            Console.WriteLine($"Tələbə əlavə olundu: {student.FullName}");
        }

        //- GetStudent() - parametr olaraq nullable int tipindən bir id dəyəri alacaq və həmin id-li Student obyektini tapıb geriyə qaytaracaq.

        public Student GetStudent(int Id)
        {
            if (Id == null)
                return null;
            foreach (var student in Students)
            {
                if (student.Id == Id)
                {
                    return student;
                }
            }
            return null;

        }

        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}
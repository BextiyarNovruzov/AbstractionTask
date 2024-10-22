using AbstractionsTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask
{
    internal abstract class User:IAccount
    {
        private static int IdCounter = 0;
        private int Id { get; set; }
        public string FullName { get; }
        public string Email { get; set; }
        public string Password {  get; }
        
        public User(int Id, string FullName, string Email, string Password)
        {
            Id = ++IdCounter; 
            this.FullName = FullName;
            this.Email = Email;
            if (PasswordChecker(Password))
            {
                this.Password = Password;   
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz Password sertleri odemir.");
            }
        }

        //- PasswordChecker() - PasswordChecker methodu - gələn string password dəyərinin şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarir.                        Şərtlər:
                        //- şifrədə minimum 8 character olmalıdır
                        //- şifrədə ən az 1 böyük hərf olmalıdır
                        //- şifrədə ən az 1 kiçik hərf olmalıdır
                        //- şifrədə ən az 1 rəqəm olmalıdır
        public  bool PasswordChecker(string password)
        {
            if (password.Length < 8) return false;         
            if (!password.Any(char.IsUpper)) return false; 
            if (!password.Any(char.IsLower)) return false; 
            if (!password.Any(char.IsDigit)) return false; 
            return true;
        }
    
        //- ShowInfo() - bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır
        public void ShowInfo()
        {
            Console.WriteLine($"User-in Id-si: {Id}\nFullname : {FullName}\n Email: {Email}"); 
        }
    }
}

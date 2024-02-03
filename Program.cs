using System;

namespace Result2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Jim";
            string pass1 = "Acillis";
            string name2 = "Joy";
            string pass2 = "Sadiya";
            string name3 = "Topu";
            string pass3 = "Afroza";
            string name4 = "Sojeb";
            string pass4 = "Humayra";
            Console.WriteLine("Please Enter Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome Back " + name);
            Console.WriteLine("Please Enter Your Password : ");
            string password = Console.ReadLine();
            string result = (name == name1 && password == pass1) ? "Your Resut is 3.68" : (name == name2 && password == pass2) ? "Your Resut is 3.80" : (name == name3 && password == pass3) ? "Your Resut is 3.40" : (name == name4 && password == pass4) ? "Your Resut is 3.20" : "Please check Your Credentials";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
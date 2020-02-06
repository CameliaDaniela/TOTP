using Application;
using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OneTimePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("ID:");
                var id = Console.ReadLine();
                var coder = new Coder();
                var oneTimePass = coder.Code(id, DateTime.UtcNow);
                Console.WriteLine("OTP:" + oneTimePass);
                Console.WriteLine("Password:");
                oneTimePass = Console.ReadLine();
                var login = coder.Verify(oneTimePass);
                if (login)
                    Console.WriteLine("Login Succesfull");
                else
                    Console.WriteLine("Please request another password");
            }
        }

    }
}

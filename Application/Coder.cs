using System;
using OtpNet;
using System.Text;

namespace Application
{
    public class Coder
    {
        private Totp Totp { set; get; }

        public string Code(string id, DateTime time)
        {
            Totp = new Totp(Encoding.ASCII.GetBytes(id), mode: OtpHashMode.Sha256, step:30);

            return Totp.ComputeTotp(time);
        }
        public bool Verify(string oneTimePass)
        {
            return  Totp.VerifyTotp(oneTimePass, out var _);
        }
       
    }
}

using System;
using System.Text;
using System.IO;

namespace EmailMarketingTool
{
    class Program
    {
        static void Main(string[] args)
        {
            //About author
            Console.WriteLine("UIT Email Marketing Tool");
            Console.WriteLine("Author: Phuc-Luan");

            ////initialize infomation
            //string toAddress = "";
            //string fromAddress = "minhhoanghoangvo@gmail.com";
            //string pass = "hoangvotong";
            //string subject = "xin chao";
            //string content = "hi";
            //int IDNumber = 15520311;

            //for (int i = 3; i <= 3; i++)
            //{
            //    //Gene  rate Email from ID 
            //    toAddress = IDNumber.ToString() + "@gm.uit.edu.vn";

            //    SendEmail.SendEmailMarketing(toAddress, fromAddress, pass, subject, content);
            //    IDNumber++;
            //}

            SendEmail.Page_Load(null, EventArgs.Empty);


        }

    }
}
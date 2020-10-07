using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHomework.Models
{
    public class VipVisitor : Visitor
    {
        public static int VipVisitorCount = 0;

        public VipVisitor(string visitorName, string visitorSurname):base (visitorName,visitorSurname)
        {
            VipVisitorCount++;
        }


        public override void MembershipPayment()
        {
            Console.WriteLine("VIP membership mokestis");
        }

        public override void BooksAllowed()
        {
            Console.WriteLine("VIP leidziamas knygu skaicius");
        }
    }
}

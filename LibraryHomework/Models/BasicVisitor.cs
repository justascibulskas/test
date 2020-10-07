using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHomework.Models
{
    public class BasicVisitor : Visitor
    {
        public static int BasicVisitorCount = 0;

        public BasicVisitor(string visitorName, string visitorSurname):base(visitorName, visitorSurname)
        {
            BasicVisitorCount++;
        }

        public override void MembershipPayment()
        {
            Console.WriteLine("nurodomas basic membershop mokestis");
        }

        public override void BooksAllowed()
        {
            Console.WriteLine( "Nurodoma basic membership leidziamu knygu skaicius");
        }




    }
}

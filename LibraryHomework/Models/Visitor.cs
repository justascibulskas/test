using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHomework.Models
{
    public abstract class Visitor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid VisitorID { get; set; }

        public static int TotalVisitorCount = 0;

        public Visitor(string visitorName, string visitorSurname)
        {
            this.Name = visitorName;
            this.Surname = visitorSurname;
            VisitorID = Guid.NewGuid();
            TotalVisitorCount++;
        }

        public virtual void MembershipPayment()
        {
            Console.WriteLine("abstract klases metodas perasomas kitiems");
        }

        public virtual void BooksAllowed()
        {
            Console.WriteLine("abstract klases metodas perasomas kitiems");
        }
    }
}

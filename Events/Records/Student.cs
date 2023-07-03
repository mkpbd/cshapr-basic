using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public record Student(string ID, string LastName, string GivenName)
    {
        public string ID { get; } = ID;
        readonly int _enrolmentYear = int.Parse(ID.Substring(0, 4));
    }

    public record struct StudentWithStruct(string ID)
    {
        public string ID = ID;
    }
}
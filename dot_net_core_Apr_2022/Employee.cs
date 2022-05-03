using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_core_Apr_2022
{
    [Serializable()]
    public class Employee : ISerializable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employee() {}

        public Employee(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Id");
            FirstName = info.GetString("FirstName");
            LastName = info.GetString("LastName");
            Salary = info.GetDouble("Salary");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("FirstName", FirstName);
            info.AddValue("LastName", LastName);
            info.AddValue("Salary", Salary);
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} - ${Salary}";
        }
    }
}

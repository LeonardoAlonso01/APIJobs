using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Core.Entities
{
    public class Job
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Location { get; private set; }
        public double Salary { get; private set; }

        public void Update(string title, string description, string location, double salary)
        {
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Application.InputModels.JobsInputModels
{
    public class UpdateJobInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public double Salary { get; set; }
    }
}

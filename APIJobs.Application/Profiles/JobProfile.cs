using APIJobs.Application.InputModels.JobsInputModels;
using APIJobs.Application.ViewModels.JobsViewModels;
using APIJobs.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Application.Profiles
{
    public class JobProfile: Profile
    {
        public JobProfile()
        {
            CreateMap<CreateJobInputModel, Job>();
            CreateMap<UpdateJobInputModel, Job>();
            CreateMap<Job, JobsViewModel>();
            CreateMap<Job, JobDetailViewModel>();
        }
    }
}

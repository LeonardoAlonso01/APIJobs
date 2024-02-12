using APIJobs.Application.InputModels.JobsInputModels;
using APIJobs.Application.ViewModels.JobsViewModels;
using APIJobs.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Application.Services.Interface
{
    public interface IJobService
    {
        Task<List<JobsViewModel>> GetJobs();
        Task<JobDetailViewModel> GetJobById(int Id);
        Task<int> CreateJob(CreateJobInputModel job);
        Task<Boolean> DeleteJob(int id);
        Task<Boolean> UpdateJob(int Id, UpdateJobInputModel job);
    }
}

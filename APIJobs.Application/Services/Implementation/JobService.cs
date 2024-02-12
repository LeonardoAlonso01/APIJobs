using APIJobs.Application.InputModels.JobsInputModels;
using APIJobs.Application.Services.Interface;
using APIJobs.Application.ViewModels.JobsViewModels;
using APIJobs.Core.Entities;
using APIJobs.Core.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Application.Services.Implementation
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateJob(CreateJobInputModel job)
        {
            var jobCreated = _mapper.Map<Job>(job);
            await _jobRepository.Add(jobCreated);

            return jobCreated.Id;
        }

        public async Task<Boolean> DeleteJob(int id)
        {
            var job = await _jobRepository.GetById(id);
            return await _jobRepository.Delete(job);
        }

        public async Task<JobDetailViewModel> GetJobById(int id)
        {
            var job = await _jobRepository.GetById(id);
            var jobViewModel = _mapper.Map<JobDetailViewModel>(job);
            return jobViewModel;
        }

        public async Task<List<JobsViewModel>> GetJobs()
        {
            var jobs = await _jobRepository.GetAll();
            var jobsViewModel = _mapper.Map<List<JobsViewModel>>(jobs);
            return jobsViewModel;
        }

        public async Task<Boolean> UpdateJob(int Id, UpdateJobInputModel job)
        {
            var jobUpdated = await _jobRepository.GetById(Id);
            jobUpdated.Update(job.Title, job.Description, job.Location, job.Salary);
            return await _jobRepository.Update();
        }
    }
}

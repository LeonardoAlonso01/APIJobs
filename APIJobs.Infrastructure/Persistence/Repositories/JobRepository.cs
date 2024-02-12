using APIJobs.Core.Entities;
using APIJobs.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Infrastructure.Persistence.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly JobsContext _context;

        public JobRepository(JobsContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Job job)
        {
            try
            {
                await _context.Jobs.AddAsync(job);
                return await _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<Boolean> Delete(Job job)
        {
            try
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Job>> GetAll()
        {
            try
            {
                var jobs = await _context.Jobs.ToListAsync();
                return jobs;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Job> GetById(int id)
        {
            try
            {
                var job = await _context.Jobs.FirstOrDefaultAsync(x => x.Id == id);
                return job;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Boolean> Update()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

using APIJobs.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Core.Repositories
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAll();
        Task<Job> GetById(int id);
        Task<int> Add(Job job);
        Task<Boolean> Delete(Job job);
        Task<Boolean> Update();

    }
}

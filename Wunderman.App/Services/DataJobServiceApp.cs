using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wunderman.App.Contracts;
using Wunderman.App.DTO.Jobs;

namespace Wunderman.App.Services
{
    public class DataJobServiceApp : IDataProcessorService
    {
        public Task<DataJobDTO> Create(DataJobDTO dataJob)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid dataJobID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DataJobDTO>> GetAllDataJobs()
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetBackgroundProcessResults(Guid dataJobId)
        {
            throw new NotImplementedException();
        }

        public Task<DataJobStatus> GetBackgroundProcessStatus(Guid dataJobId)
        {
            throw new NotImplementedException();
        }

        public Task<DataJobDTO> GetDataJob(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DataJobDTO>> GetDataJobsByStatus(DataJobStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<bool> StartBackgroundProcess(Guid dataJobId)
        {
            throw new NotImplementedException();
        }

        public Task<DataJobDTO> Update(DataJobDTO dataJob)
        {
            throw new NotImplementedException();
        }
    }
}

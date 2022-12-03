using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wunderman.App.DTO.Jobs;

namespace Wunderman.App.Contracts
{
    public interface IDataProcessorService
    {
            Task<IEnumerable<DataJobDTO>> GetAllDataJobs();
            Task<IEnumerable<DataJobDTO>> GetDataJobsByStatus(DataJobStatus status);
            Task<DataJobDTO> GetDataJob(Guid id);
            Task<DataJobDTO> Create(DataJobDTO dataJob);
            Task<DataJobDTO> Update(DataJobDTO dataJob);
            Task Delete(Guid dataJobID);
            Task<bool> StartBackgroundProcess(Guid dataJobId);
            Task<DataJobStatus> GetBackgroundProcessStatus(Guid dataJobId);
            Task<List<string>> GetBackgroundProcessResults(Guid dataJobId);
    }
}

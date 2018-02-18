using Abp.Application.Services;
using SamerCs.Tasks.Dto;
using System.Collections.Generic;

namespace SamerCs.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        IList<TaskVm> GetAll();
    }
}
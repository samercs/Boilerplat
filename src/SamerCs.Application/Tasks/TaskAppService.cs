using Abp.Domain.Repositories;
using AutoMapper;
using SamerCs.TaskModel;
using SamerCs.Tasks.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SamerCs.Tasks
{
    public class TaskAppService : SamerCsAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _repository;

        public TaskAppService(IRepository<Task> repository)
        {
            _repository = repository;
        }
        public IList<TaskVm> GetAll()
        {
            var allTasks = _repository.GetAll().ToList();
            var result = Mapper.Map<List<Task>, List<TaskVm>>(allTasks);
            return result;
        }
    }
}
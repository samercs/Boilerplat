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
            return ObjectMapper.Map<List<TaskVm>>(allTasks);
        }

        public TaskVm Create(TaskVm taskVm)
        {
            var task = ObjectMapper.Map<Task>(taskVm);
            return ObjectMapper.Map<TaskVm>(_repository.Insert(task));
        }
    }
}
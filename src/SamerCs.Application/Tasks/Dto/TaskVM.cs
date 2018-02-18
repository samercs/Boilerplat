using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using SamerCs.TaskModel;
using System;

namespace SamerCs.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskVm : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.ComponentModel.DataAnnotations;

namespace SamerCs.TaskModel
{
    public class Task : Entity, IHasCreationTime
    {
        public Task()
        {
            State = TaskState.Open;
            CreationTime = Clock.Now;
        }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
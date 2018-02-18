using System.Collections.Generic;
using SamerCs.Tasks.Dto;

namespace SamerCs.Web.Models.Tasks
{
    public class IndexVm
    {
        public IList<TaskVm> Tasks { get; set; }
        public TaskVm Task { get; set; }
    }
}
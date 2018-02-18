using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamerCs.Controllers;
using SamerCs.Tasks;
using SamerCs.Tasks.Dto;
using SamerCs.Web.Models.Tasks;

namespace SamerCs.Web.Mvc.Controllers
{
    public class TasksController : SamerCsControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }
        public IActionResult Index()
        {
            var data = _taskAppService.GetAll();
            var model = new IndexVm
            {
                Tasks = data,
                Task = new TaskVm()
            };
            
            return View(model);
        }

        public IActionResult Add(TaskVm taskVm)
        {
            _taskAppService.Create(taskVm);
            return RedirectToAction("Index");
        }
    }
}
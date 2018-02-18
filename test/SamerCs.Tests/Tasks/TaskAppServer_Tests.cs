using System.Collections.Generic;
using SamerCs.Tasks;
using SamerCs.Tasks.Dto;
using Shouldly;
using Xunit;

namespace SamerCs.Tests.Tasks
{
    public class TaskAppServer_Tests: SamerCsTestBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskAppServer_Tests(ITaskAppService appService)
        {
            _taskAppService = appService;
        }

        /*[Fact]
        public void Should_GetAll()
        {
            var all = _taskAppService.GetAll();
            all.Count.ShouldBe(2);
        }*/
    }
}
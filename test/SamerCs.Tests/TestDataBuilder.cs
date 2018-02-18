using SamerCs.EntityFrameworkCore;
using SamerCs.TaskModel;

namespace SamerCs.Tests
{
    public class TestDataBuilder
    {
        private readonly SamerCsDbContext _context;

        public TestDataBuilder(SamerCsDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Tasks.AddRange(
                new Task {Title = "Follow the white rabbit", Description = "Follow the white rabbit in order to know the reality."},
                new Task{Title = "Clean your room",  State = TaskState.Completed }
            );
        }
    }
}
using System.Collections.Generic;
using TodoAPI.Models;

namespace TodoAPI.Data {
    public class MockRepo : ITaskRepo
    {
        public Task GetTaskById(int id)
        {
            return new Task{Id = 100, Description = "test task", Name = "test", Time = new System.DateTime()};
        }

        public IEnumerable<Task> GetTaskList()
        {
            return new List<Task> {
                new Task{Id = 0, Description = "my task 1", Name = "task 1", Time = new System.DateTime()},
                new Task{Id = 1, Description = "my task 2", Name = "task 2", Time = new System.DateTime()},
                new Task{Id = 2, Description = "my task 3", Name = "task 3", Time = new System.DateTime()},
                new Task{Id = 3, Description = "my task 4", Name = "task 4", Time = new System.DateTime()},
            };
        }
    }
}
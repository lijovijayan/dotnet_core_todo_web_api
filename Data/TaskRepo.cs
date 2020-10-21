using System.Collections.Generic;
using TodoAPI.Models;

namespace TodoAPI.Data {
    public class TaskRepo : ITaskRepo
    {
        public Task GetTaskById(int id)
        {
            return new Task{Id = 0, Description = "test task", Name = "test", Time = new System.DateTime()};
        }

        public IEnumerable<Task> GetTaskList()
        {
            return new List<Task> {
                new Task{Id = 0, Description = "test task", Name = "test", Time = new System.DateTime()},
                new Task{Id = 0, Description = "test task", Name = "test", Time = new System.DateTime()},
                new Task{Id = 0, Description = "test task", Name = "test", Time = new System.DateTime()},
                new Task{Id = 0, Description = "test task", Name = "test", Time = new System.DateTime()},
                new Task{Id = 0, Description = "test task", Name = "test", Time = new System.DateTime()},
            };
        }
    }
}
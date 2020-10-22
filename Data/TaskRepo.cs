using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TodoAPI.Models;

namespace TodoAPI.Data
{
    public class TaskRepo : ITaskRepo
    {
        private readonly TaskContext _context;
        public TaskRepo(TaskContext context)
        {
            _context = context;
        }
        public Task GetTaskById(int id)
        {
            return _context.Tasks.FirstOrDefault(task => task.Id == id);
        }

        public IEnumerable<Task> GetTaskList()
        {
            return _context.Tasks.ToList();
        }
    }
}

using System.Collections.Generic;
using TodoAPI.Models;

namespace TodoAPI.Data {
    public interface ITaskRepo {
        IEnumerable<Task> GetTaskList();
        Task GetTaskById(int id);
    }
}

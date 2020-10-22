using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Data;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly TaskRepo _repository;
        public TodoListController(TaskRepo repository) {
            _repository = repository;
        }
        // /api/TodoList
        [HttpGet]
        public ActionResult <IEnumerable<Task>> GetTaskResult()
        {
            return Ok(_repository.GetTaskList());
        }
        [HttpGet("{id}")]
        public ActionResult<Task> GetTaskById(int id)
        {
            return Ok(_repository.GetTaskById(id));
        }
    }
}

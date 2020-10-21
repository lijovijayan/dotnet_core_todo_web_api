using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Data;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoListController : ControllerBase
    {
        // /api/TodoList
        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return new TaskRepo().GetTaskList();
        }
    }
}

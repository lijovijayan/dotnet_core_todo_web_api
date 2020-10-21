using System;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Data;
using TodoAPI.Models;

namespace TodoAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class TodoListController: ControllerBase {
         // /api/TodoList
        [HttpGet]
        public Task Get() {
            return new TaskRepo().GetTaskById(0);
        }
    }
}
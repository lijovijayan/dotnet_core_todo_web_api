using System;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;

namespace TodoAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    class TodoListController: ControllerBase {
        public static Task[] tasks;
        // /api/TodoList
        [HttpGet]
        public string Get() {
            return "Hello World !";
        }
    }
}
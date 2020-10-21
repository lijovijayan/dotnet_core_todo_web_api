using System;
namespace TodoAPI.Models
{
    public class Task
    {
        // public Task() {

        // }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
    }
}
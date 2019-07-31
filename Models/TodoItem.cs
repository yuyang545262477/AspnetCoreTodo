using System;

namespace AspnetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid id { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}
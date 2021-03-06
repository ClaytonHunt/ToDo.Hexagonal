﻿using System.ComponentModel.DataAnnotations;

namespace ToDo.Shared
{
    public class TodoItem
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Text { get; set; }

        public bool IsCompleted { get; set; }
    }
}

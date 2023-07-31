﻿using TasksSytems.Enums;

namespace TasksSytems.Models
{
    public class TaskModel
    {

        public int Id { get; set; }

        public string? Name { get; set; }
        
        public string? Description { get; set; }

        public StatusTask Status { get; set; }
    }
}

﻿
using System.Collections.Generic;

namespace task123.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Time { get; internal set; }
        public List<Question> Questions { get; set; }
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<Result> Results { get; set; }
        public List<TestTheme> TestThemes { get; set; }
    }
}

﻿using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface ITestsPageView
    {
        public List<Test> Tests { get; set; }
        public bool EditButtonVisible { get; set; }
        public Test SelectedTest { get; }
    }
}

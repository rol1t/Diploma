using diploma.Models;
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
        public List<Subject> Subjects { get; set; }
        public Subject SelectedSubject { get; }
        public List<Theme> Themes { get; set; }
        public Theme SelectedTheme { get; }
        public Test SelectedTest { get; }
    }
}

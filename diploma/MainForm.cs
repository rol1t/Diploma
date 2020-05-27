using diploma.Models;
using diploma.Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    public partial class MainForm : MaterialForm, IMainView
    {
        public User User { get; }
        Form IMainView.MainForm => this;

        public MainForm(User result)
        {
            InitializeComponent();
            User = result;
        }
    }
}

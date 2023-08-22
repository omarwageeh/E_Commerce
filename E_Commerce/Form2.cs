using E_Commerce.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Form2 : Form
    {
        private readonly AdminService _adminService;
        public Form2(AdminService adminService)
        {
            _adminService = adminService;
            InitializeComponent();
        }
    }
}

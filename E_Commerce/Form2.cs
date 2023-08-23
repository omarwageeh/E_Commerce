using E_Commerce.Dto;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDto productDto = new ProductDto()
            {
                NameEn = textBox1.Text,
                NameAr = textBox2.Text,
                UnitPrice = decimal.Parse(textBox3.Text),
                StockQuantity = int.Parse(textBox4.Text),
                catName = textBox5.Text,
            };
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            _adminService.AddProduct(productDto);
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var products = (await _adminService.GetProducts(p => p.NameEn.Contains(textBox1.Text))).ToList();
            dataGridView1.Columns.Add("NameEn", "NameEn");
            dataGridView1.Columns.Add("NameAr", "NameAr");
            dataGridView1.Columns.Add("UnitPrice", "UnitPrice");
            dataGridView1.Columns.Add("Units in Stock", "NameEn");
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.NameEn, product.NameAr, product.UnitPrice, product.StockQuantity);
            }
        }
    }
}

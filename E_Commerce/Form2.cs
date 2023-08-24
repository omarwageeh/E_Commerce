using E_Commerce.Dto;
using E_Commerce.Model.Enum;
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
            dataGridView1.Columns.Clear();
            var products = (await _adminService.GetProducts(p => p.NameEn.Contains(textBox1.Text)))?.ToList();
            dataGridView1.Columns.Add("NameEn", "NameEn");
            dataGridView1.Columns.Add("NameAr", "NameAr");
            dataGridView1.Columns.Add("UnitPrice", "UnitPrice");
            dataGridView1.Columns.Add("Units in Stock", "Units in Stock");
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.NameEn, product.NameAr, product.UnitPrice, product.StockQuantity);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            var categories = (await _adminService.GetCategories(c => c.Name.Contains(textBox6.Text)))?.ToList();
            dataGridView1.Columns.Add("Name", "Name");
            foreach (var category in categories)
            {
                dataGridView1.Rows.Add(category.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBox6.Text;
            textBox6.Clear();
            _adminService.AddCategory(name);
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            var orders = (await _adminService.GetOrders())?.ToList();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Customer Name", "Customer Name");
            dataGridView1.Columns.Add("Status", "Status");
            foreach (var order in orders)
            {
                dataGridView1.Rows.Add(order.Id, order.Customer.FullName, order.Status);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Insert a valid order status");
                return;

            }
            if(textBox7.Text == "")
            {
                MessageBox.Show("Insert a valid order id");
                return;
            }
            var orderId = Guid.Parse(textBox7.Text);

            Status orderStatus = (Status) comboBox1.SelectedIndex;

            _adminService.UpdateOrder(orderId, orderStatus);

        }
    }
}

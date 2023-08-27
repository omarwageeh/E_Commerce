using E_Commerce.Model;
using E_Commerce.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Form3 : Form
    {
        private readonly CustomerService _customerService;
        private User _user;
        public event EventHandler<UserEventArgs> OrderPlaced;
        public Form3(CustomerService customerService)
        {
            _customerService = customerService;
            OrderPlaced += func;
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var orderId = textBox3.Text;
            var prodId = textBox2.Text;
            var orderDetails = await _customerService.GetOrderDetails(orderId, prodId);
            var order = await _customerService.GetOrders(o => o.Id == Guid.Parse(orderId));
            var product = await _customerService.GetProducts(p => p.Id == Guid.Parse(prodId));
            if (orderDetails == null || product.FirstOrDefault() == null || order.FirstOrDefault() == null)
            {
                return;
            }
            orderDetails.ProductCount += 1;
            order.FirstOrDefault().TotalPrice += product.First().UnitPrice;
            _customerService.UpdateOrder(order.First());
            product.First().StockQuantity -= 1;
            _customerService.UpdateProduct(product.First());
            _customerService.UpdateOrderDetails(orderDetails);

        }
        public void SetUser(User user)
        {
            _user = user;
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Product Id", "Product Id");
            dataGridView1.Columns.Add("NameEn", "NameEn");
            dataGridView1.Columns.Add("NameAr", "NameAr");
            dataGridView1.Columns.Add("UnitPrice", "UnitPrice");
            dataGridView1.Columns.Add("Units in Stock", "Units in Stock");
            dataGridView1.Columns.Add("Category", "Category");

            if (comboBox1.SelectedItem == "Category")
            {
                var products = (await _customerService.GetProducts(p => p.Category.Name.Contains(textBox2.Text)))?.ToList();
                foreach (var product in products)
                {
                    dataGridView1.Rows.Add(product.Id, product.NameEn, product.NameAr, product.UnitPrice, product.StockQuantity, product.Category.Name);
                }
            }
            else if (comboBox1.SelectedItem == "Price")
            {
                var products = (await _customerService.GetProducts(p => p.UnitPrice <= int.Parse(textBox2.Text)))?.ToList();
                foreach (var product in products)
                {
                    dataGridView1.Rows.Add(product.Id, product.NameEn, product.NameAr, product.UnitPrice, product.StockQuantity, product.Category.Name);
                }
            }
            else if (comboBox1.SelectedItem == "Name")
            {
                var products = (await _customerService.GetProducts(p => p.NameEn.Contains(textBox2.Text)))?.ToList();
                foreach (var product in products)
                {
                    dataGridView1.Rows.Add(product.Id, product.NameEn, product.NameAr, product.UnitPrice, product.StockQuantity, product.Category.Name);
                }
            }


        }
        private async void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            var orders = (await _customerService.GetOrders(o => o.Customer.Id == _user.Id))?.ToList();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Customer Name", "Customer Name");
            dataGridView1.Columns.Add("Total Price", "Total Price");
            dataGridView1.Columns.Add("Status", "Status");

            foreach (var order in orders)
            {
                dataGridView1.Rows.Add(order.Id, order.Customer.FullName, order.TotalPrice, order.Status);
            }


        }
        private async void button4_Click(object sender, EventArgs e)
        {
            var orderId = textBox3.Text;
            var prodId = textBox2.Text;
            var orderDetails = await _customerService.GetOrderDetails(orderId, prodId);
            var order = await _customerService.GetOrders(o => o.Id == Guid.Parse(orderId));
            var product = await _customerService.GetProducts(p => p.Id == Guid.Parse(prodId));
            if (orderDetails == null || product.FirstOrDefault() == null || order.FirstOrDefault() == null)
            {
                return;
            }
            orderDetails.ProductCount -= 1;
            product.First().StockQuantity += 1;
            order.FirstOrDefault().TotalPrice -= product.First().UnitPrice;
            if (orderDetails.ProductCount == 0)
            {
                await _customerService.RemoveOrderDetails(orderId, prodId);
            }
            else
            {
                _customerService.UpdateOrderDetails(orderDetails);
            }
            _customerService.UpdateOrder(order.First());
            _customerService.UpdateProduct(product.First());
          
        }
        private async void button5_Click(object sender, EventArgs e)
        {

            var prodId = textBox2.Text;
            var prod = await _customerService.GetProducts(p => p.Id == Guid.Parse(prodId) && p.StockQuantity > 0);
            if (prod.FirstOrDefault() == null)
                return;
            prod.FirstOrDefault()!.StockQuantity -= 1;
            _customerService.UpdateProduct(prod.FirstOrDefault()!);
            Order order = new Order();
            order.Status = Model.Enum.Status.Pending;
            order.TotalPrice += prod.FirstOrDefault()!.UnitPrice;
            order.Customer = _user as Customer;
            _customerService.AddOrder(order);
            OrderDetails details = new OrderDetails();
            details.Product = prod.FirstOrDefault()!;
            details.Order = order;
            details.ProductCount = 1;
            details.UnitPrice = prod.FirstOrDefault()!.UnitPrice;
            _customerService.AddOrderDetails(details);

            OrderPlaced.Invoke(this, new UserEventArgs()
            {
                UserId = _user.Id,
                OrderId = order.Id,
                CreatedOn = order.CreatedOn,
            });
        }

        private void func(object? sender, UserEventArgs e)
        {
            Debug.WriteLine($"{e.UserId}, {e.OrderId}, {e.CreatedOn}");
        }


    }
}

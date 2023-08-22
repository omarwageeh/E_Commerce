using E_Commerce.Dto;
using E_Commerce.Model;
using E_Commerce.Service;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce
{
    public partial class Form1 : Form
    {
        private readonly UserService _userService;
        private User? user;
        public Form1(UserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
           user = await _userService.LoginUser(userNameBox.Text, passwordBox.Text);
            if(user !=null)
            {
                Form2 f2 = Program.ServiceProvider.GetRequiredService<Form2>();
                //f2.Owner = this;
                f2.Show();
                this.Close();
            }
        }
    }
}
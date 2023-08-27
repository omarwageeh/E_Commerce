using E_Commerce.Dto;
using E_Commerce.Model;
using E_Commerce.Service;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce
{
    public partial class Form1 : Form
    {
        private UserService _userService;
        private User? _user;
        public Form1(UserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
           _user = await _userService.LoginUser(userNameBox.Text, passwordBox.Text);
            if(_user !=null)
            {
                if(_user is Admin) {
                    Form2 f2 = Program.ServiceProvider.GetRequiredService<Form2>();
                    //f2.Owner = this;
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    Form3 f3 = Program.ServiceProvider.GetRequiredService<Form3>();
                    //f2.Owner = this;
                    f3.Show();
                    f3.SetUser(_user);
                    this.Hide();
                }

            }
        }
    }
}
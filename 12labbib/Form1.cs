using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _12labbib
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        private AppDbContext context;
        public Form1(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User{
                Name = textBox1.Text,
                Email = textBox5.Text,
                Password = textBox2.Text
            };
            _context.Users.Add(user); 
            _context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _12labbib
{
    public partial class Form2 : Form
    {
        private AppDbContext context;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user; 
            using (var context = new AppDbContext()) 
            { 
                var email = textBox1.Text; 
                var password = textBox2.Text; 
                user = context.Users.FirstOrDefault(u => u.Name == email && u.Password == password); 
            }
            if (user != null)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(context, user);
                Hide();
                mainForm.ShowDialog();
                DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) Close();
                else if (dialogResult == DialogResult.No) Show();
            }
            else
                MessageBox.Show("Нет");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registrationForm = new Form1(new AppDbContext()); 
            this.Hide(); 
            registrationForm.ShowDialog(); 
            Show();
        }
    }
}


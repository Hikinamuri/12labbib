using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12labbib
{
    public partial class SaleForm : Form
    {
        private readonly AppDbContext _context; 
        private readonly User _user; 
        public Sales Book { get; private set; }
        public SaleForm(AppDbContext context, User user) 
        { 
            InitializeComponent();
            _context = new AppDbContext();
            _user = user; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var book = new Sales 
            { 
                Date = textBox1.Text,
                Client = textBox2.Text,
                Tovar = int.Parse(textBox3.Text),
                Number = int.Parse(textBox4.Text),
                UserId = _user.Id
            };
            _context.Books.Add(book); 
            _context.SaveChanges(); 
            Book = book; 
            DialogResult = DialogResult.OK;
        }
    }
}

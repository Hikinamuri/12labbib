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
    public partial class BookForm : Form
    {
        private readonly AppDbContext _context; 
        private readonly User _user; 
        public Book Book { get; private set; }
        public BookForm(AppDbContext context, User user) 
        { 
            InitializeComponent();
            _context = new AppDbContext();
/*            _context = context; */
            _user = user; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var book = new Book 
            { 
                Title = textBox1.Text,
                Author = textBox2.Text,
                Year = int.Parse(textBox3.Text),
                UserId = _user.Id
            };
            _context.Books.Add(book); 
            _context.SaveChanges(); 
            Book = book; 
            DialogResult = DialogResult.OK;
        }
    }
}

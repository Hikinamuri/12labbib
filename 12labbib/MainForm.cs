using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _12labbib
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        public MainForm(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _user = user;
            Text = $"Библиотека пользователя {_user.Name}";
            update();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm(_context, _user); 
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                _user.Books.Add(bookForm.Book);
                update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
            var bookToRemove = _context.Books.FirstOrDefault(b => b.Id == id);
            _context.Books.Remove(bookToRemove);
            _context.SaveChanges();
            update();
        }

        private void update()
        {
            List<Book> booksWithUserId = _context.Books.Where(b => b.UserId == _user.Id).ToList();
            dataGridView2.DataSource = booksWithUserId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDbDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDbDataSet.Books);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.FillBy(this.libraryDbDataSet.Books, ((int)(System.Convert.ChangeType(iDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

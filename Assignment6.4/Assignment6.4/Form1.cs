using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6._4
{
    public partial class Form1 : Form
    {

        BookRepository bookRepository;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            bookRepository = new BookRepository();
            BookGrid.DataSource = bookRepository.GetAllRecords();
            BtnUpdate.Enabled = false;
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAuthor.Text) && !string.IsNullOrEmpty(txtCopies.Text) && !string.IsNullOrEmpty(txtDate.Text) && !string.IsNullOrEmpty(txtISBN.Text) && !string.IsNullOrEmpty(txtID.Text))
            {

                var newBook = new Book();
                newBook.BookId = Int32.Parse(txtID.Text);
                newBook.ISBN = txtISBN.Text;
                newBook.Author = txtAuthor.Text;
                newBook.BookName = txtName.Text;
                newBook.Copies = txtCopies.Text;
                newBook.ReleaseDate = txtDate.Text;
                bookRepository.AddRecord(newBook);
                MessageBox.Show("Book added");
                Clear();
            }
        }

        private void Clear()
        {
            txtAuthor.Clear();
            txtCopies.Clear();
            txtDate.Clear();
            txtID.Clear();
            txtISBN.Clear();
            txtName.Clear();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BookGrid.DataSource = null;
            BookGrid.DataSource = bookRepository.GetAllRecords();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var ID = BookGrid.CurrentRow.Cells[0].Value;
            var BookDelete = bookRepository.FindBook((int)ID);
            bookRepository.DeleteRecord(BookDelete);
            MessageBox.Show("Book deleted");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var ID = BookGrid.CurrentRow.Cells[0].Value;
            var bookToUpdate = bookRepository.FindBook((int)ID);

            txtID.Text = bookToUpdate.BookId.ToString();
            txtISBN.Text = bookToUpdate.ISBN;
            txtName.Text = bookToUpdate.BookName;
            txtAuthor.Text = bookToUpdate.Author;
            txtDate.Text = bookToUpdate.ReleaseDate;
            txtCopies.Text = bookToUpdate.Copies;
            BtnUpdate.Enabled = true;
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtID.Text);

            var bookToUpdate = bookRepository.FindBook((int)id);
             bookToUpdate.ISBN = txtISBN.Text;
            bookToUpdate.BookName = txtName.Text;
            bookToUpdate.Author = txtAuthor.Text;
            bookToUpdate.ReleaseDate = txtDate.Text;
            bookToUpdate.Copies = txtCopies.Text;
            BtnUpdate.Enabled = true;
            Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID.Text = (bookRepository.GetMaxId() + 1).ToString();
            txtID.ReadOnly = true;
            txtName.Clear();
            txtAuthor.Clear();
            txtCopies.Clear();
            txtDate.Clear();
            txtISBN.Clear();
        }
        }
    }

using PelayoFirstApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelayoFirstApp
{
    public partial class frmCategoryUpdate : Form
    {
        private int _id;
        private BindingSource _bindingSource;
        private readonly pelayoCoopEntities _context = new pelayoCoopEntities();

        public frmCategoryUpdate()
        {
            InitializeComponent();
        }

        public frmCategoryUpdate(int ID, BindingSource bindingSource) : this()
        {
            _id = ID;
            _bindingSource = bindingSource;
        }

        private void frmCategoryUpdate_Load(object sender, EventArgs e)
        {
            var selectedCategory = _context.Categories.Where(q => q.Id == _id).FirstOrDefault();
            textBox1.Text = selectedCategory.CategoryName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedCategory = _context.Categories.Where(q => q.Id == _id).FirstOrDefault();

            selectedCategory.CategoryName = textBox1.Text.Trim();

            _context.SaveChanges();

            _bindingSource.DataSource = _context.Categories.ToList();

            this.Close();
        }
    }
}

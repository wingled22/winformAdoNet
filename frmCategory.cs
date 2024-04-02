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
    public partial class frmCategory : Form
    {
        private readonly pelayoCoopEntities _context = new pelayoCoopEntities();

        private int SelectedCategoryId;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = _context.Categories.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            SelectedCategoryId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategoryUpdate form = new frmCategoryUpdate(SelectedCategoryId, categoryBindingSource);
            form.ShowDialog();
        }
    }
}

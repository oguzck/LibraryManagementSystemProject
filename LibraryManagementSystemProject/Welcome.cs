using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemProject
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadForm(new SearchInterface());
        }

        private void btnBorrowedBooks_Click(object sender, EventArgs e)
        {
            loadForm(new BarrowedBooks());
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            loadForm(new AdminPage());
        }
    }
}

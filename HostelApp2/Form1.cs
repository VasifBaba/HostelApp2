using HostelApp2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelApp2
{
    
    public partial class Form1 : Form
    {
        hostelDBEntities db = new hostelDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmbl.Text = "Compar Hostel";
            lblmbl.Location = new Point((this.ClientSize.Width - lblmbl.Size.Width) / 2, 20);
            pcImage.Image = new Bitmap(@"C:\Users\User\Source\Repos\HostelApp2\HostelApp2\image\abc.png");
            pcImage.Location = new Point((this.ClientSize.Width - pcImage.Size.Width) / 2,
                 (this.ClientSize.Height - pcImage.Size.Height) / 2);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.ShowDialog();
        }
    }
}

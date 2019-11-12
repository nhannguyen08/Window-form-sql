using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddAnSangForm : Form
    {
        public AddAnSangForm()
        {
            InitializeComponent();
            this.btnThemmoi.Click +=btnThemmoi_Click;
        }

        void btnThemmoi_Click(object sender, EventArgs e)
        {
            var tenMon = this.txtTenMon.Text;
            var giaTien = int.Parse(this.txtGiaTien.Text);
            var anSang = new AnSang();
            anSang.TenMon = tenMon;
            anSang.GiaTien = giaTien;

            var db = new QuanAnEntities();
            db.AnSangs.Add(anSang);
            db.SaveChanges();

            MessageBox.Show("Mon an da them thanh cong!!");
            this.Close();
        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ViewAnSangFromm : Form
    {
        public ViewAnSangFromm()
        {
            InitializeComponent();
            this.Load += ViewAnSangFromm_Load;
            this.btnAddAnSang.Click += btnAddAnSang_Click;
        }

        void btnAddAnSang_Click(object sender, EventArgs e)
        {
            var form = new AddAnSangForm();
            form.ShowDialog(); //hoan thanh form hien thi , ko thao tac dc 2 form
            this.ShowAnSangList();
        }

        void ViewAnSangFromm_Load(object sender, EventArgs e)
        {
            this.ShowAnSangList();
        }
        private void ShowAnSangList()
        {
            QuanAnEntities db = new QuanAnEntities();
            AnSang[] list = db.AnSangs.ToArray();
            this.GRDAnSang.DataSource = list;

        }
    }
}

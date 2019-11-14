using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnExpenditures.Click += btnExpenditures_Click;
        }

        void btnExpenditures_Click(object sender, EventArgs e)
        {
            //(new ViewExpendituresForm()).ShowDialog(); đặt ẩn danh
            var form = new ViewExpendituresForm();
            form.ShowDialog();
        }
    }
}

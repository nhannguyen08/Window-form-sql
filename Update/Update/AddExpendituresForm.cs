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
    public partial class AddExpendituresForm : Form
    {
        public AddExpendituresForm()
        {
            InitializeComponent();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = this.ptbDate.Value;
            string note = this.txtNote.Text;
            int price = Decimal.ToInt32(this.nudPrice.Value);

            var expenditure = new Expenditure();
            expenditure.Date = date;
            expenditure.Note = note;
            expenditure.Price = price;

            var db = new OOPCSEntities();
            db.Expenditures.Add(expenditure);
            db.SaveChanges();
            this.Close();
        }
    }
}

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
    public partial class ViewExpendituresForm : Form
    {
        public ViewExpendituresForm()
        {
            InitializeComponent();
            this.Load += ViewExpendituresForm_Load;
            this.btnAddNewExpenditures.Click += btnAddNewExpenditures_Click;
            this.grdExpenditures.KeyDown += grdExpenditures_KeyDown;
        }

        void grdExpenditures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (this.grdExpenditures.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Do you want to delete this!") == System.Windows.Forms.DialogResult.OK)
                    {
                        ExpendituresView selected = (ExpendituresView)this.grdExpenditures.SelectedRows[0].DataBoundItem;
                        var db = new OOPCSEntities();
                        Expenditure deleted = db.Expenditures.Find(selected.id);
                        db.Expenditures.Remove(deleted);
                        db.SaveChanges();
                        this.ViewAllExpenditures();
                    }
                }
            }
                
        }

        
        void btnAddNewExpenditures_Click(object sender, EventArgs e)
        {
            (new AddExpendituresForm()).ShowDialog();
            this.ViewAllExpenditures();
        }

        void ViewExpendituresForm_Load(object sender, EventArgs e)
        {
            this.ViewAllExpenditures();
        }
        private void ViewAllExpenditures()
        {
            var db = new OOPCSEntities();
            var expenditures = db.Expenditures.ToArray();

            var expendituresView = new ExpendituresView[expenditures.Length];
            for (int i = 0; i < expenditures.Length; i++)
                expendituresView[i] = new ExpendituresView(expenditures[i]);

            this.grdExpenditures.DataSource = expendituresView;
        }
    }
}

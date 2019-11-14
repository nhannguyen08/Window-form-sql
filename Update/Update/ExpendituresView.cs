using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
    public class ExpendituresView
    {
        public int id { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }
        public string Price { get; set; }


        public ExpendituresView(Expenditure expenditures)
        {
            this.id = expenditures.id;
            this.Date = String.Format("Ngay {0}/{1} ", expenditures.Date.Day, expenditures.Date.Month);
            this.Note = expenditures.Note;
            this.Price = String.Format("{0:n0}", expenditures.Price);
        }
    }
}

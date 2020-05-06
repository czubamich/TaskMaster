using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMaster
{
    public partial class frmNewTime : Form
    {
        public int Result
        {
            get { return dateTimePicker1.Value.Hour * 60*60+dateTimePicker1.Value.Minute*60 + dateTimePicker1.Value.Second; }
        }

        public frmNewTime(int timeInSec)
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today + TimeSpan.FromSeconds(timeInSec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

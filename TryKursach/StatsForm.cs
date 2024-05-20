using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryKursach
{
    public partial class StatsForm : Form
    {
        public Prisoners MyPrison;

        public StatsForm(MainForm parent)
        {
            MyPrison = parent.MyPrison;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            try
            {
                StatsLabel.Text = MyPrison.FormStatistics();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Please , Check your data!\n" + ex.Message);
            }

        }

        private void StatsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

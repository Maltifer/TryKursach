using System;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TryKursach
{
    public partial class AddFormFamily : Form
    {
        public Family MyFamily;

        private AddFormFamily() { }


        public AddFormFamily(Family f)
        {
            MyFamily = f;
            //IDtextBox.Enabled = true;
            InitializeComponent();
        }        
        public AddFormFamily(Family f, int Id)
        {
            MyFamily = f;

            InitializeComponent();
            IDtextBox.Text = Id.ToString();
            IDtextBox.Enabled = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    AddButton_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        public Relative LoadPrisonerFromInput()
        {
            try
            {
                return new Relative(
                        firstName: FirstNameTextBox.Text,
                        secondName: SecondNameTextBox.Text,
                        patronimyc: PatronymicTextBox.Text,
                        ID: IDtextBox.Text,
                        relation: RelationTextBox.Text
                        );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Please , Check your data!\n" + ex.Message);
            }
            //?????????
            return null;
        }

        protected virtual void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyFamily.Add(LoadPrisonerFromInput());
                /*                MainForm otherForm = (MainForm)Application.OpenForms["MainForm"];
                                otherForm.ShowStatisticsButton.Enabled = true;
                                otherForm.FamilyButton.Enabled = true;*/
                this.Close();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CellBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PersonalityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

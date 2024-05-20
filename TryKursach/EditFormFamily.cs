using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//TODO: passing MyPrison as parameter, not the whole form
namespace TryKursach
{
    public partial class EditFormFamily : AddFormFamily
    {
        public new Family MyFamily;
        private int uniqueID;
        private EditFormFamily(Family f) : base(f) { }

        public EditFormFamily(Family f, int uniqueId) : base(f)
        {
            MyFamily = f;
            uniqueID = uniqueId;
            this.InitializeComponent();

            LoadDataToInputFields();
            

            AddButton.Text = "Сохранить";
            IDtextBox.Enabled = false;
        }        


        private void LoadDataToInputFields()
        {
            Relative p = MyFamily.family.First(x => x.uniqueId == uniqueID);

            FirstNameTextBox.Text = p.FirstName;
            SecondNameTextBox.Text = p.SecondName;
            PatronymicTextBox.Text = p.Patronymic;
            IDtextBox.Text = p.Id.ToString();
            RelationTextBox.Text = p.Relation;
        }


        protected override void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyFamily.Replace(uniqueID, LoadPrisonerFromInput());
                this.Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections;*/
namespace TryKursach
{

    public partial class FamilyFormForSelected : Form
    {
        private int size = 120;

        public Prisoners MyPrison;

        public Family MyFamily;

        public bool Ascending = false;

        System.Media.SoundPlayer player;
        public int ID;

        public FamilyFormForSelected(Prisoners ps, int Id)
        {
            MyPrison = ps;
            MyFamily = new Family(ps);
            ID = Id;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FamilyFormForSelected_FormClosed);
            player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\Users\\danil\\source\\repos\\TryKursach\\TryKursach\\03-Fool.wav";
        }

        public Dictionary<string, Func<Relative, string>> selectedFields = new Dictionary<string, Func<Relative, string>>()
        {
            { "Родич",r=>r.Id.ToString() },
            { "Ім'я",r=>r.FirstName },
            { "Прізвище",r=>r.SecondName },
            { "По-батькові",r=>r.Patronymic },
            { "Спорі́дненість",r=>r.Relation }
        };

        //List View

        private void FamilyFormForSelected_Load(object sender, EventArgs e)
        {

            FamilyListView.View = System.Windows.Forms.View.Details;
            FamilyListView.GridLines = true;
            FamilyListView.FullRowSelect = true;

            FamilyListView.MouseDoubleClick += new MouseEventHandler(FamilyListView_DoubleClick);


            string[] fieldNames = selectedFields.Keys.ToArray();

            for (int i = 0; i < fieldNames.Length; i++)
            {
                FamilyListView.Columns.Add(fieldNames[i], size);
                SearchFieldComboBox.Items.Add(fieldNames[i]);
            }


            FamilyListView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
            SearchFieldComboBox.SelectedIndex = 0;
            try
            {
                MyFamily.Load();
                RefreshedFamily(MyFamily.family);


                RefreshView(MyFamily.family);
            }
            catch (Exception ex)
            {
            }


        }






        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Delete:
                    DeleteButton_Click(null, null);
                    break;
                case Keys.F11:
                    EditButton_Click(null, null);
                    break;
                case Keys.F12:
                    AddPrisonerButton_Click(null, null);
                    break;
                case Keys.Enter:
                    SearchButton_Click(null, null);
                    break;
                case Keys.Pause:
                    MessageBox.Show("A.Y.E");
                    PlayMuzon();
                    break;
                case Keys.Escape:
                    MessageBox.Show("A.Y.E(Stop(((((()");
                    StopMuzon();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void FamilyListView_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(null, null);
        }


        public void RefreshView(List<Relative> rl)
        {
            FamilyListView.Items.Clear();
            foreach (Relative r in rl)
            {
                if (r.Id == ID)
                {
                    List<string> row = new List<string>();

                    foreach (Func<Relative, string> f in selectedFields.Values)
                    {
                        row.Add(f(r));
                    }

                    FamilyListView.Items.Add(new ListViewItem(row.ToArray()));
                }

            }

            FamilyListView.Focus();

            FamilyListView.MultiSelect = false;
        }
        public void RefreshedFamily(List<Relative> rl)
        {

            /*            foreach (Relative r in rl)
                        {
                            if (!MyPrison.prisoners.Exists(x => x.Id == r.Id))
                            {
                                rl.RemoveAll(x => x.Id == r.Id);
                            }
                        }*/
            /*            int zxc = 0;
                        while (MyFamily.family.Count != 0 && zxc < MyFamily.family.Count)
                        {
                            if (!MyPrison.prisoners.Exists(x => x.Id == MyFamily.family[zxc].Id))
                            {
                                 MyFamily.Remove(MyFamily.family[zxc].Id);
                                zxc = 0;
                            }
                            zxc++;
                        }  */
            int zxc = MyFamily.family.Count - 1;
            while (MyFamily.family.Count != 0 && zxc >= 0)
            {
                if (!MyPrison.prisoners.Exists(x => x.Id == MyFamily.family[zxc].Id))
                {
                    MyFamily.Remove(MyFamily.family[zxc].Id);
                    zxc = MyFamily.family.Count - 1;
                }
                else
                {
                    zxc--;
                }

            }
            MyFamily.Save();
        }

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            Func<Relative, string> field = selectedFields.Values.ToList()[e.Column];
            RefreshView(MyFamily.OrderBy(field, Ascending));
            Ascending = !Ascending;
        }





        //BUTTONS


        private void AddPrisonerButton_Click(object sender, EventArgs e)
        {
            var myForm = new AddFormFamily(MyFamily, ID);
            myForm.Show();
            myForm.FormClosed += MyForm_FormClosed;
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (FamilyListView.SelectedItems.Count == 1)
            {
                int myUniqueId = MyFamily.selectedFamily[FamilyListView.SelectedIndices[0]].uniqueId;
                var myForm = new EditFormFamily(MyFamily, myUniqueId);
                myForm.Show();
                myForm.FormClosed += MyForm_FormClosed;
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FamilyListView.SelectedItems.Count == 1)
            {
                int myId = MyFamily.selectedFamily[FamilyListView.SelectedIndices[0]].uniqueId;
                try
                {
                    MyFamily.Remove(myId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            RefreshView(MyFamily.selectedFamily);
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string pattern = SearchTextBox.Text;
            Func<Relative, string> field = selectedFields.Values.ToList()[SearchFieldComboBox.SelectedIndex];
            bool strict = IsStrictCheckBox.Checked;
            RefreshView(MyFamily.SearchBy(field, pattern, strict));
        }


        private void TestDataButton_Click(object sender, EventArgs e)
        {
            MyFamily.CreateFixed(ID);
            //ShowStatisticsButton.Enabled = true;
            RefreshView(MyFamily.family);
            //MyFamily.Save();
        }






        private void PlayMuzon()
        {
            try
            {
                player.Play();
            }
            catch (Exception e) { }
        }
        private void StopMuzon()
        {
            try
            {
                player.Stop();
            }
            catch (Exception e) { }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MyFamily.Clear();
            //ShowStatisticsButton.Enabled = false;
            RefreshView(MyFamily.family);
        }




        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshView(MyFamily.family);
        }


        public void ReloadCols()
        {
            string[] fieldNames = selectedFields.Keys.ToArray();

            FamilyListView.Columns.Clear();
            SearchFieldComboBox.Items.Clear();
            for (int i = 0; i < fieldNames.Length; i++)
            {
                FamilyListView.Columns.Add(fieldNames[i], size);
                SearchFieldComboBox.Items.Add(fieldNames[i]);
            }
        }

        private void PrisonersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*        private void FamilyForm_FormClosedRefreshView(object sender, FormClosedEventArgs e)
                {
                    RefreshView(MyFamily.family);
                }*/
        private void FamilyFormForSelected_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyFamily.Save();
            MainForm otherForm = (MainForm)Application.OpenForms["MainForm"];
            otherForm.SelectedPrisonerFamilyButton.Enabled = true;
            otherForm.FamilyButton.Enabled = true;
        }

        private void RefreshButtom_Click(object sender, EventArgs e)
        {
            RefreshedFamily(MyFamily.family);
            RefreshView(MyFamily.family);
        }
    }
}

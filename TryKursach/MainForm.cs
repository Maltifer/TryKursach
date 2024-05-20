using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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

    public partial class MainForm : Form
    {
        private int size = 120;

        public Prisoners MyPrison = new Prisoners();

        public bool Ascending = false;

        /*        public Dictionary<string, Func<Prisoner, string>> selectedFields = new Dictionary<string, Func<Prisoner, string>>()
                {
                    { "Номер",p=>p.Id.ToString() },
                    { "Фамилия",p=>p.SecondName },
                    { "Возраст",p=>p.Age.ToString() },
                    { "Статья",p=>p.Article.ToString() },
                    { "Камера",p=>p.Cell.ToString() },
                    { "Ост. дней",p=>p.SentenceDaysLeft.ToString() },
                    { "Иерархич.",p=>p.Hierarchy },
                    { "Срок(лет)",p=>p.Sentence.Years.ToString() },
                    { "Характер",p=>p.Personality },
                };*/


        public Dictionary<string, Func<Prisoner, string>> selectedFields = new Dictionary<string, Func<Prisoner, string>>()
        {
            { "Номер",p=>p.Id.ToString() },
            { "Ім'я",p=>p.FirstName },
            { "Прізвище",p=>p.SecondName },
            { "По-батькові",p=>p.Patronymic },
            { "Вік",p=>p.Age.ToString() },
            { "Стаття",p=>p.Article.ToString() },
            { "Камера",p=>p.Cell.ToString() },
            { "Зал. днів",p=>p.SentenceDaysLeft.ToString() },
            { "Ієрархія",p=>p.Hierarchy },
            { "Строк(років)",p=>p.Sentence.Years.ToString() },
            { "Характер",p=>p.Personality },
        };

        System.Media.SoundPlayer player;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Prisoners ps)
        {
            MyPrison = ps;
            InitializeComponent();
            PrisonersListView.SelectedIndexChanged += PrisonersListView_SelectedIndexChanged;
            player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\Users\\danil\\source\\repos\\TryKursach\\TryKursach\\03-Fool.wav";

        }


        //List View

        private void MainForm_Load(object sender, EventArgs e)
        {

            PrisonersListView.View = System.Windows.Forms.View.Details;
            PrisonersListView.GridLines = true;
            PrisonersListView.FullRowSelect = true;

            PrisonersListView.MouseDoubleClick += new MouseEventHandler(PrisonersListView_DoubleClick);
            ConvoyButton.Enabled = false;
            this.MouseClick += new MouseEventHandler(InitializeConvoyButton);
            string[] fieldNames = selectedFields.Keys.ToArray();

            for (int i = 0; i < fieldNames.Length; i++)
            {
                PrisonersListView.Columns.Add(fieldNames[i], size);
                SearchFieldComboBox.Items.Add(fieldNames[i]);
            }


            PrisonersListView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
            SearchFieldComboBox.SelectedIndex = 0;

            MyPrison.Load();
            RefreshView(MyPrison.prisoners);

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



        private void PrisonersListView_DoubleClick(object sender, EventArgs e)
        {
            EditButton_Click(null, null);
        }


        public void RefreshView(List<Prisoner> ps)
        {
            PrisonersListView.Items.Clear();
            foreach (Prisoner p in ps)
            {
                List<string> row = new List<string>();

                foreach (Func<Prisoner, string> f in selectedFields.Values)
                {
                    row.Add(f(p));
                }

                PrisonersListView.Items.Add(new ListViewItem(row.ToArray()));
            }

            PrisonersListView.Focus();

            PrisonersListView.MultiSelect = false;
            ConvoyButton.Enabled = PrisonersListView.SelectedItems.Count > 0;
        }

        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            Func<Prisoner, string> field = selectedFields.Values.ToList()[e.Column];
            RefreshView(MyPrison.OrderBy(field, Ascending));
            Ascending = !Ascending;
        }





        //BUTTONS

        private void ShowStatisticsButton_Click(object sender, EventArgs e)
        {
            var myForm = new StatsForm(this);
            myForm.StartPosition = FormStartPosition.Manual;
            myForm.Location = new Point(
                this.Left + (this.Width - myForm.Width) / 2,
                this.Top + (this.Height - myForm.Height) / 2
            );
            myForm.Show();
        }


        private void AddPrisonerButton_Click(object sender, EventArgs e)
        {
            var myForm = new AddForm(MyPrison);
            myForm.Show();
            myForm.FormClosed += MyForm_FormClosed;
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                int myId = MyPrison.selectedPrisoners[PrisonersListView.SelectedIndices[0]].Id;
                var myForm = new EditForm(MyPrison, myId);
                myForm.Show();
                myForm.FormClosed += MyForm_FormClosed;
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                int myId = MyPrison.selectedPrisoners[PrisonersListView.SelectedIndices[0]].Id;
                try
                {
                    MyPrison.Remove(myId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    RefreshView(MyPrison.selectedPrisoners);
                }
            }
            if (MyPrison.selectedPrisoners.Count == 0)
            {
                FamilyButton.Enabled = false;
            }
            RefreshView(MyPrison.selectedPrisoners);
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string pattern = SearchTextBox.Text;
            Func<Prisoner, string> field = selectedFields.Values.ToList()[SearchFieldComboBox.SelectedIndex];
            bool strict = IsStrictCheckBox.Checked;
            RefreshView(MyPrison.SearchBy(field, pattern, strict));
        }


        private void TestDataButton_Click(object sender, EventArgs e)
        {
            MyPrison.Create();
            ShowStatisticsButton.Enabled = true;
            FamilyButton.Enabled = true;
            RefreshView(MyPrison.prisoners);
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
            MyPrison.Clear();
            ShowStatisticsButton.Enabled = false;
            FamilyButton.Enabled = false;
            RefreshView(MyPrison.prisoners);
        }

        private void ConvoyButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                int myId = MyPrison.selectedPrisoners[PrisonersListView.SelectedIndices[0]].Id;
                var myForm = new ConvoyForm(MyPrison, myId);
                myForm.Show();
                myForm.FormClosed += MyForm_FormClosed;
            }
        }


        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshView(MyPrison.prisoners);
        }


        public void ReloadCols()
        {
            string[] fieldNames = selectedFields.Keys.ToArray();

            PrisonersListView.Columns.Clear();
            SearchFieldComboBox.Items.Clear();
            for (int i = 0; i < fieldNames.Length; i++)
            {
                PrisonersListView.Columns.Add(fieldNames[i], size);
                SearchFieldComboBox.Items.Add(fieldNames[i]);
            }
        }

        private void colsEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadCols();
            RefreshView(MyPrison.selectedPrisoners);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new ViewConvoysForm(MyPrison);
            myForm.Show();
            myForm.FormClosed += MyForm_FormClosed;
        }
        private void InitializeConvoyButton(object sender, EventArgs e)
        {
            // Изначально кнопка отключена
            ConvoyButton.Enabled = false;

            // Пример настройки кнопки, если она не настроена в дизайнере
            // button1.Text = "Do Action";
        }
        private void PrisonersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvoyButton.Enabled = PrisonersListView.SelectedItems.Count > 0;
        }

        public void FamilyButton_Click(object sender, EventArgs e)
        {
            var myForm = new FamilyForm(MyPrison);
            myForm.Show();
            //myForm.FormClosed += MyForm_FormClosed;
            FamilyButton.Enabled = false;
            SelectedPrisonerFamilyButton.Enabled = false;
        }

        private void SaveIntxtButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Prisoner p in MyPrison.selectedPrisoners)
            {
                sb.AppendLine("///////////////////////////////////");
                for (int i = 0; selectedFields.Count > i; i++)
                {
                    string key = selectedFields.Keys.ElementAt(i);
                    Func<Prisoner, string> value = selectedFields.Values.ElementAt(i);
                    sb.AppendLine(key + ":    " + value(p));
                }
                sb.AppendLine("///////////////////////////////////");
            }
            MyPrison.SaveIntxt(sb.ToString());
        }

        private void SelectedPrisonerFamilyButton_Click(object sender, EventArgs e)
        {
            if (PrisonersListView.SelectedItems.Count == 1)
            {
                int myId = MyPrison.selectedPrisoners[PrisonersListView.SelectedIndices[0]].Id;
                var myForm = new FamilyFormForSelected(MyPrison, myId);
                myForm.Show();
                //myForm.FormClosed += MyForm_FormClosed;
                SelectedPrisonerFamilyButton.Enabled = false;
                FamilyButton.Enabled = false;
            }
/*            if (PrisonersListView.SelectedItems.Count == 1)
            {
                int myId = MyPrison.selectedPrisoners[PrisonersListView.SelectedIndices[0]].Id;
                var myForm = new ConvoyForm(MyPrison, myId);
                myForm.Show();
                myForm.FormClosed += MyForm_FormClosed;
            }*/
        }
    }
}

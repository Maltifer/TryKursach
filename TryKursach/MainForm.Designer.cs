namespace TryKursach
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ShowStatisticsButton = new Button();
            AddPrisonerButton = new Button();
            PrisonersListView = new ListView();
            DeleteButton = new Button();
            SearchFieldComboBox = new ComboBox();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            TestDataButton = new Button();
            EditButton = new Button();
            IsStrictCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            ConvoysButton = new Button();
            ConvoyButton = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ClearButton = new Button();
            groupBox4 = new GroupBox();
            FamilyButton = new Button();
            SaveIntxtButton = new Button();
            groupBox5 = new GroupBox();
            SelectedPrisonerFamilyButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // ShowStatisticsButton
            // 
            ShowStatisticsButton.Location = new Point(6, 21);
            ShowStatisticsButton.Name = "ShowStatisticsButton";
            ShowStatisticsButton.Size = new Size(92, 37);
            ShowStatisticsButton.TabIndex = 1;
            ShowStatisticsButton.Text = "Статистика";
            ShowStatisticsButton.UseVisualStyleBackColor = true;
            ShowStatisticsButton.Click += ShowStatisticsButton_Click;
            // 
            // AddPrisonerButton
            // 
            AddPrisonerButton.BackColor = Color.FromArgb(0, 192, 0);
            AddPrisonerButton.Location = new Point(0, 8);
            AddPrisonerButton.Name = "AddPrisonerButton";
            AddPrisonerButton.Size = new Size(81, 54);
            AddPrisonerButton.TabIndex = 2;
            AddPrisonerButton.Text = "Додати";
            AddPrisonerButton.UseVisualStyleBackColor = false;
            AddPrisonerButton.Click += AddPrisonerButton_Click;
            // 
            // PrisonersListView
            // 
            PrisonersListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrisonersListView.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PrisonersListView.GridLines = true;
            PrisonersListView.Location = new Point(12, 210);
            PrisonersListView.Name = "PrisonersListView";
            PrisonersListView.Size = new Size(913, 442);
            PrisonersListView.TabIndex = 3;
            PrisonersListView.UseCompatibleStateImageBehavior = false;
            PrisonersListView.View = View.Details;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(87, 8);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 54);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchFieldComboBox
            // 
            SearchFieldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchFieldComboBox.FormattingEnabled = true;
            SearchFieldComboBox.Location = new Point(146, 45);
            SearchFieldComboBox.Name = "SearchFieldComboBox";
            SearchFieldComboBox.Size = new Size(167, 23);
            SearchFieldComboBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Microsoft Sans Serif", 10F);
            SearchButton.Location = new Point(319, 13);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(105, 56);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 10F);
            SearchTextBox.Location = new Point(6, 13);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(307, 23);
            SearchTextBox.TabIndex = 7;
            // 
            // TestDataButton
            // 
            TestDataButton.Location = new Point(6, 64);
            TestDataButton.Name = "TestDataButton";
            TestDataButton.Size = new Size(92, 39);
            TestDataButton.TabIndex = 8;
            TestDataButton.Text = "Тест";
            TestDataButton.UseVisualStyleBackColor = true;
            TestDataButton.Click += TestDataButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(168, 8);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(81, 54);
            EditButton.TabIndex = 9;
            EditButton.Text = "Змінити";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // IsStrictCheckBox
            // 
            IsStrictCheckBox.AutoSize = true;
            IsStrictCheckBox.Font = new Font("Microsoft Sans Serif", 7F);
            IsStrictCheckBox.Location = new Point(31, 49);
            IsStrictCheckBox.Name = "IsStrictCheckBox";
            IsStrictCheckBox.Size = new Size(71, 17);
            IsStrictCheckBox.TabIndex = 10;
            IsStrictCheckBox.Text = "точн. збіг";
            IsStrictCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 11;
            label1.Text = "F12";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(112, 65);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 12;
            label2.Text = "Del";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(190, 65);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 13;
            label3.Text = "F11";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EditButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(AddPrisonerButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DeleteButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 85);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // ConvoysButton
            // 
            ConvoysButton.Location = new Point(112, 22);
            ConvoysButton.Name = "ConvoysButton";
            ConvoysButton.Size = new Size(81, 54);
            ConvoysButton.TabIndex = 17;
            ConvoysButton.Text = "Обзор Конвоїв";
            ConvoysButton.UseVisualStyleBackColor = true;
            ConvoysButton.Click += button2_Click;
            // 
            // ConvoyButton
            // 
            ConvoyButton.Location = new Point(6, 22);
            ConvoyButton.Name = "ConvoyButton";
            ConvoyButton.Size = new Size(81, 54);
            ConvoyButton.TabIndex = 14;
            ConvoyButton.Text = "Новий Конвой";
            ConvoyButton.UseVisualStyleBackColor = true;
            ConvoyButton.Click += ConvoyButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(SearchButton);
            groupBox2.Controls.Add(SearchFieldComboBox);
            groupBox2.Controls.Add(IsStrictCheckBox);
            groupBox2.Controls.Add(SearchTextBox);
            groupBox2.Location = new Point(370, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 85);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(ClearButton);
            groupBox3.Controls.Add(TestDataButton);
            groupBox3.Controls.Add(ShowStatisticsButton);
            groupBox3.Location = new Point(820, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(105, 170);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(6, 109);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(92, 39);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "Очистити";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ConvoyButton);
            groupBox4.Controls.Add(ConvoysButton);
            groupBox4.Location = new Point(34, 103);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 87);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            // 
            // FamilyButton
            // 
            FamilyButton.Location = new Point(6, 18);
            FamilyButton.Name = "FamilyButton";
            FamilyButton.Size = new Size(90, 56);
            FamilyButton.TabIndex = 19;
            FamilyButton.Text = "Пергляд усіх родичів";
            FamilyButton.UseVisualStyleBackColor = true;
            FamilyButton.Click += FamilyButton_Click;
            // 
            // SaveIntxtButton
            // 
            SaveIntxtButton.Location = new Point(689, 121);
            SaveIntxtButton.Name = "SaveIntxtButton";
            SaveIntxtButton.Size = new Size(91, 56);
            SaveIntxtButton.TabIndex = 20;
            SaveIntxtButton.Text = "Зберегти інформацію";
            SaveIntxtButton.UseVisualStyleBackColor = true;
            SaveIntxtButton.Click += SaveIntxtButton_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(SelectedPrisonerFamilyButton);
            groupBox5.Controls.Add(FamilyButton);
            groupBox5.Location = new Point(299, 103);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(205, 87);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            // 
            // SelectedPrisonerFamilyButton
            // 
            SelectedPrisonerFamilyButton.Location = new Point(102, 18);
            SelectedPrisonerFamilyButton.Name = "SelectedPrisonerFamilyButton";
            SelectedPrisonerFamilyButton.Size = new Size(97, 56);
            SelectedPrisonerFamilyButton.TabIndex = 20;
            SelectedPrisonerFamilyButton.Text = "Пергляд родичів";
            SelectedPrisonerFamilyButton.UseVisualStyleBackColor = true;
            SelectedPrisonerFamilyButton.Click += SelectedPrisonerFamilyButton_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Info;
            ClientSize = new Size(937, 664);
            Controls.Add(groupBox5);
            Controls.Add(SaveIntxtButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PrisonersListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 0);
            Name = "MainForm";
            Text = "Тюрьма";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.Button ShowStatisticsButton;
        private System.Windows.Forms.Button AddPrisonerButton;
        private System.Windows.Forms.ListView PrisonersListView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox SearchFieldComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button TestDataButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.CheckBox IsStrictCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ConvoyButton;
        private System.Windows.Forms.Button ConvoysButton;
        private GroupBox groupBox4;
        public Button FamilyButton;
        public Button SaveIntxtButton;
        private GroupBox groupBox5;
        public Button SelectedPrisonerFamilyButton;
    }
}


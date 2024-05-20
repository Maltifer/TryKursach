namespace TryKursach
{
    partial class FamilyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyForm));
            AddPrisonerButton = new Button();
            FamilyListView = new ListView();
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            RefreshButtom = new Button();
            ClearButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            // FamilyListView
            // 
            FamilyListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FamilyListView.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FamilyListView.GridLines = true;
            FamilyListView.Location = new Point(12, 117);
            FamilyListView.Name = "FamilyListView";
            FamilyListView.Size = new Size(511, 333);
            FamilyListView.TabIndex = 3;
            FamilyListView.UseCompatibleStateImageBehavior = false;
            FamilyListView.View = View.Details;
            FamilyListView.SelectedIndexChanged += PrisonersListView_SelectedIndexChanged;
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
            SearchFieldComboBox.Location = new Point(131, 46);
            SearchFieldComboBox.Name = "SearchFieldComboBox";
            SearchFieldComboBox.Size = new Size(131, 23);
            SearchFieldComboBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Microsoft Sans Serif", 10F);
            SearchButton.Location = new Point(268, 13);
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
            SearchTextBox.Size = new Size(256, 23);
            SearchTextBox.TabIndex = 7;
            // 
            // TestDataButton
            // 
            TestDataButton.Location = new Point(7, 22);
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
            IsStrictCheckBox.Location = new Point(6, 50);
            IsStrictCheckBox.Name = "IsStrictCheckBox";
            IsStrictCheckBox.Size = new Size(112, 17);
            IsStrictCheckBox.TabIndex = 10;
            IsStrictCheckBox.Text = "точн. совпадение";
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
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(SearchButton);
            groupBox2.Controls.Add(SearchFieldComboBox);
            groupBox2.Controls.Add(IsStrictCheckBox);
            groupBox2.Controls.Add(SearchTextBox);
            groupBox2.Location = new Point(283, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 85);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(RefreshButtom);
            groupBox3.Controls.Add(ClearButton);
            groupBox3.Controls.Add(TestDataButton);
            groupBox3.Location = new Point(551, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(105, 169);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // RefreshButtom
            // 
            RefreshButtom.Location = new Point(7, 112);
            RefreshButtom.Name = "RefreshButtom";
            RefreshButtom.Size = new Size(91, 38);
            RefreshButtom.TabIndex = 17;
            RefreshButtom.Text = "Refresh";
            RefreshButtom.UseVisualStyleBackColor = true;
            RefreshButtom.Click += RefreshButtom_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(7, 67);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(92, 39);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "Очистити";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // FamilyForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(674, 462);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(FamilyListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(690, 589);
            MinimumSize = new Size(690, 400);
            Name = "FamilyForm";
            Text = "Родственники";
            Load += FamilyForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button AddPrisonerButton;
        private System.Windows.Forms.ListView FamilyListView;
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
        private Button RefreshButtom;
    }
}


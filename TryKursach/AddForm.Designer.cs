namespace TryKursach
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            NameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SecondNameTextBox = new TextBox();
            ArticleBox = new TextBox();
            CellBox = new TextBox();
            BirthdayLabel = new Label();
            BirthdayPicker = new DateTimePicker();
            FirstNameTextBox = new TextBox();
            label3 = new Label();
            PatronymicTextBox = new TextBox();
            label4 = new Label();
            SentenceYearsBox = new TextBox();
            label5 = new Label();
            ImprisonedDatePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            HierarchyPlaceTextBox = new TextBox();
            SentenceMonthsBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            PersonalityTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.Location = new Point(192, 372);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(162, 55);
            AddButton.TabIndex = 0;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(84, 20);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Прізвище";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 173);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Камера";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Стаття";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Location = new Point(150, 20);
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(223, 23);
            SecondNameTextBox.TabIndex = 5;
            SecondNameTextBox.Text = "Іванов";
            // 
            // ArticleBox
            // 
            ArticleBox.Location = new Point(150, 147);
            ArticleBox.Name = "ArticleBox";
            ArticleBox.Size = new Size(223, 23);
            ArticleBox.TabIndex = 7;
            ArticleBox.Text = "228";
            // 
            // CellBox
            // 
            CellBox.Location = new Point(150, 173);
            CellBox.Name = "CellBox";
            CellBox.Size = new Size(223, 23);
            CellBox.TabIndex = 8;
            CellBox.Text = "-1";
            CellBox.TextChanged += CellBox_TextChanged;
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Location = new Point(47, 98);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(103, 15);
            BirthdayLabel.TabIndex = 9;
            BirthdayLabel.Text = "Дата народження";
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.Location = new Point(150, 98);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(223, 23);
            BirthdayPicker.TabIndex = 10;
            BirthdayPicker.Value = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(150, 46);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(223, 23);
            FirstNameTextBox.TabIndex = 12;
            FirstNameTextBox.Text = "Іван";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 46);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "Ім'я";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(150, 72);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(223, 23);
            PatronymicTextBox.TabIndex = 14;
            PatronymicTextBox.Text = "Іванович";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 72);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 13;
            label4.Text = "По-батькові";
            label4.Click += label4_Click;
            // 
            // SentenceYearsBox
            // 
            SentenceYearsBox.Location = new Point(150, 200);
            SentenceYearsBox.Name = "SentenceYearsBox";
            SentenceYearsBox.Size = new Size(50, 23);
            SentenceYearsBox.TabIndex = 16;
            SentenceYearsBox.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 200);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Термін";
            // 
            // ImprisonedDatePicker
            // 
            ImprisonedDatePicker.Location = new Point(150, 223);
            ImprisonedDatePicker.Name = "ImprisonedDatePicker";
            ImprisonedDatePicker.Size = new Size(223, 23);
            ImprisonedDatePicker.TabIndex = 18;
            ImprisonedDatePicker.Value = new DateTime(2016, 4, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 17;
            label6.Text = "Заключен под стражу";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 251);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 19;
            label7.Text = "Место в иерархии";
            // 
            // HierarchyPlaceTextBox
            // 
            HierarchyPlaceTextBox.Location = new Point(150, 251);
            HierarchyPlaceTextBox.Name = "HierarchyPlaceTextBox";
            HierarchyPlaceTextBox.Size = new Size(223, 23);
            HierarchyPlaceTextBox.TabIndex = 20;
            HierarchyPlaceTextBox.Text = "Мужик";
            // 
            // SentenceMonthsBox
            // 
            SentenceMonthsBox.Location = new Point(251, 197);
            SentenceMonthsBox.Name = "SentenceMonthsBox";
            SentenceMonthsBox.Size = new Size(50, 23);
            SentenceMonthsBox.TabIndex = 21;
            SentenceMonthsBox.Text = "5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 201);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 22;
            label8.Text = "Років";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(303, 200);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 23;
            label9.Text = "Місяців";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(PersonalityTextBox);
            groupBox1.Controls.Add(SecondNameTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(SentenceMonthsBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(HierarchyPlaceTextBox);
            groupBox1.Controls.Add(ArticleBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(CellBox);
            groupBox1.Controls.Add(ImprisonedDatePicker);
            groupBox1.Controls.Add(BirthdayLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(BirthdayPicker);
            groupBox1.Controls.Add(SentenceYearsBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(FirstNameTextBox);
            groupBox1.Controls.Add(PatronymicTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(80, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 332);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 283);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 25;
            label10.Text = "Характер\r\n";
            label10.Click += label10_Click;
            // 
            // PersonalityTextBox
            // 
            PersonalityTextBox.Location = new Point(150, 280);
            PersonalityTextBox.Name = "PersonalityTextBox";
            PersonalityTextBox.Size = new Size(223, 23);
            PersonalityTextBox.TabIndex = 24;
            PersonalityTextBox.Text = "Фрік\r\n";
            PersonalityTextBox.TextChanged += PersonalityTextBox_TextChanged;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 480);
            Controls.Add(groupBox1);
            Controls.Add(AddButton);
            Name = "AddForm";
            Text = "Добавление";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SecondNameTextBox;
        public System.Windows.Forms.TextBox ArticleBox;
        public System.Windows.Forms.TextBox CellBox;
        private System.Windows.Forms.Label BirthdayLabel;
        public System.Windows.Forms.DateTimePicker BirthdayPicker;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox SentenceYearsBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker ImprisonedDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox SentenceMonthsBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox HierarchyPlaceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label label10;
        public TextBox PersonalityTextBox;
    }
}
namespace TryKursach
{
    partial class AddFormFamily
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
            SecondNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label3 = new Label();
            PatronymicTextBox = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            RelationTextBox = new TextBox();
            label1 = new Label();
            IDtextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.Location = new Point(142, 248);
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
            NameLabel.Location = new Point(36, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Прізвище";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Location = new Point(102, 22);
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(223, 23);
            SecondNameTextBox.TabIndex = 5;
            SecondNameTextBox.Text = "Иванов";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(102, 48);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(223, 23);
            FirstNameTextBox.TabIndex = 12;
            FirstNameTextBox.Text = "Иван";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 48);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "Ім'я";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(102, 74);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(223, 23);
            PatronymicTextBox.TabIndex = 14;
            PatronymicTextBox.Text = "Иванович";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 74);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 13;
            label4.Text = "По-батькові";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(RelationTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(IDtextBox);
            groupBox1.Controls.Add(SecondNameTextBox);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(FirstNameTextBox);
            groupBox1.Controls.Add(PatronymicTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(50, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 181);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 135);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 18;
            label2.Text = "Спорі́дненість";
            // 
            // RelationTextBox
            // 
            RelationTextBox.Location = new Point(102, 132);
            RelationTextBox.Name = "RelationTextBox";
            RelationTextBox.Size = new Size(223, 23);
            RelationTextBox.TabIndex = 17;
            RelationTextBox.Text = "Батько";
            RelationTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 106);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 16;
            label1.Text = "Номер";
            label1.Click += label1_Click_1;
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(102, 103);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(223, 23);
            IDtextBox.TabIndex = 15;
            IDtextBox.Text = "-1";
            IDtextBox.TextChanged += IDtextBox_TextChanged;
            // 
            // AddFormFamily
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 326);
            Controls.Add(groupBox1);
            Controls.Add(AddButton);
            MaximumSize = new Size(460, 365);
            MinimumSize = new Size(460, 365);
            Name = "AddFormFamily";
            Text = "Добавление";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox SecondNameTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public TextBox IDtextBox;
        private Label label1;
        private Label label2;
        public TextBox RelationTextBox;
    }
}
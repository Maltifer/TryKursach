namespace TryKursach
{
    partial class StatsForm
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
            StatsLabel = new Label();
            SuspendLayout();
            // 
            // StatsLabel
            // 
            StatsLabel.Location = new Point(10, 8);
            StatsLabel.Name = "StatsLabel";
            StatsLabel.Size = new Size(370, 335);
            StatsLabel.TabIndex = 1;
            StatsLabel.Text = "label1";
            StatsLabel.Click += StatsLabel_Click;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 230);
            Controls.Add(StatsLabel);
            Name = "StatsForm";
            Text = "StatsForm";
            Load += StatsForm_Load;
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.Label StatsLabel;
    }
}
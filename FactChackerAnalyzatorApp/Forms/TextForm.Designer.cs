namespace FactChackerAnalyzatorApp
{
    partial class TextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            _btnExit = new Button();
            _btnAnalyzate = new Button();
            _lblEnterText = new Label();
            _rtbMainText = new RichTextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // _btnExit
            // 
            _btnExit.BackColor = SystemColors.ButtonHighlight;
            _btnExit.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnExit.Location = new Point(833, 573);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(217, 95);
            _btnExit.TabIndex = 5;
            _btnExit.Text = "EXIT";
            _btnExit.UseVisualStyleBackColor = false;
            _btnExit.Click += _btnExit_Click;
            // 
            // _btnAnalyzate
            // 
            _btnAnalyzate.BackColor = Color.DarkOrange;
            _btnAnalyzate.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnAnalyzate.Location = new Point(1093, 573);
            _btnAnalyzate.Name = "_btnAnalyzate";
            _btnAnalyzate.Size = new Size(217, 95);
            _btnAnalyzate.TabIndex = 6;
            _btnAnalyzate.Text = "ANALYZATE";
            _btnAnalyzate.UseVisualStyleBackColor = false;
            _btnAnalyzate.Click += _btnAnalyzate_Click;
            // 
            // _lblEnterText
            // 
            _lblEnterText.AutoSize = true;
            _lblEnterText.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point, 238);
            _lblEnterText.Location = new Point(35, 23);
            _lblEnterText.Name = "_lblEnterText";
            _lblEnterText.Size = new Size(430, 54);
            _lblEnterText.TabIndex = 7;
            _lblEnterText.Text = "VLOŽTE TEXT/ČLÁNEK:";
            // 
            // _rtbMainText
            // 
            _rtbMainText.BackColor = SystemColors.ButtonHighlight;
            _rtbMainText.Location = new Point(35, 80);
            _rtbMainText.Name = "_rtbMainText";
            _rtbMainText.Size = new Size(654, 571);
            _rtbMainText.TabIndex = 0;
            _rtbMainText.Text = "";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1186, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1322, 720);
            Controls.Add(pictureBox2);
            Controls.Add(_rtbMainText);
            Controls.Add(_lblEnterText);
            Controls.Add(_btnAnalyzate);
            Controls.Add(_btnExit);
            Name = "TextForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _btnExit;
        private Button _btnAnalyzate;
        private Label _lblEnterText;
        private RichTextBox _rtbMainText;
        private PictureBox pictureBox2;
    }
}
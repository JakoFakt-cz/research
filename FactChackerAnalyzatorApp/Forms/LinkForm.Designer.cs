namespace FactChackerAnalyzatorApp.Forms
{
    partial class LinkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkForm));
            _btnExit = new Button();
            _btnAnalyzate = new Button();
            _lblEnterText = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // _btnExit
            // 
            _btnExit.BackColor = SystemColors.ButtonFace;
            _btnExit.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnExit.Location = new Point(650, 215);
            _btnExit.Name = "_btnExit";
            _btnExit.Size = new Size(217, 95);
            _btnExit.TabIndex = 6;
            _btnExit.Text = "EXIT";
            _btnExit.UseVisualStyleBackColor = false;
            _btnExit.Click += _btnExit_Click;
            // 
            // _btnAnalyzate
            // 
            _btnAnalyzate.BackColor = Color.DarkOrange;
            _btnAnalyzate.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnAnalyzate.Location = new Point(915, 215);
            _btnAnalyzate.Name = "_btnAnalyzate";
            _btnAnalyzate.Size = new Size(217, 95);
            _btnAnalyzate.TabIndex = 7;
            _btnAnalyzate.Text = "ANALYZOVAT";
            _btnAnalyzate.UseVisualStyleBackColor = false;
            _btnAnalyzate.Click += _btnAnalyzate_Click;
            // 
            // _lblEnterText
            // 
            _lblEnterText.AutoSize = true;
            _lblEnterText.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point, 238);
            _lblEnterText.Location = new Point(44, 38);
            _lblEnterText.Name = "_lblEnterText";
            _lblEnterText.Size = new Size(312, 54);
            _lblEnterText.TabIndex = 8;
            _lblEnterText.Text = "VLOŽTE ODKAZ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(976, 31);
            textBox1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1064, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // LinkForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1186, 338);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(_lblEnterText);
            Controls.Add(_btnAnalyzate);
            Controls.Add(_btnExit);
            Name = "LinkForm";
            Text = "LinkForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _btnExit;
        private Button _btnAnalyzate;
        private Label _lblEnterText;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
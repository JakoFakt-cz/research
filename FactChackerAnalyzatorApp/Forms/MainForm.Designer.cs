namespace FactChackerAnalyzatorApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            _lblWelcomeText = new Label();
            _btnTextFormEnter = new Button();
            _btnLinkFormEnter = new Button();
            _btnEnd = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // _lblWelcomeText
            // 
            _lblWelcomeText.AutoSize = true;
            _lblWelcomeText.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            _lblWelcomeText.Location = new Point(154, 88);
            _lblWelcomeText.Name = "_lblWelcomeText";
            _lblWelcomeText.Size = new Size(1139, 88);
            _lblWelcomeText.TabIndex = 0;
            _lblWelcomeText.Text = "VÍTEJTE VE FACT-CHACKING APLIKACI";
            _lblWelcomeText.TextAlign = ContentAlignment.TopCenter;
            // 
            // _btnTextFormEnter
            // 
            _btnTextFormEnter.BackColor = Color.DarkOrange;
            _btnTextFormEnter.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            _btnTextFormEnter.Location = new Point(154, 436);
            _btnTextFormEnter.Name = "_btnTextFormEnter";
            _btnTextFormEnter.Size = new Size(281, 132);
            _btnTextFormEnter.TabIndex = 1;
            _btnTextFormEnter.Text = "TEXT";
            _btnTextFormEnter.UseVisualStyleBackColor = false;
            _btnTextFormEnter.Click += _btnTextFormEnter_Click;
            // 
            // _btnLinkFormEnter
            // 
            _btnLinkFormEnter.BackColor = SystemColors.ButtonHighlight;
            _btnLinkFormEnter.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            _btnLinkFormEnter.Location = new Point(581, 436);
            _btnLinkFormEnter.Name = "_btnLinkFormEnter";
            _btnLinkFormEnter.Size = new Size(281, 132);
            _btnLinkFormEnter.TabIndex = 2;
            _btnLinkFormEnter.Text = "ODKAZ";
            _btnLinkFormEnter.UseVisualStyleBackColor = false;
            _btnLinkFormEnter.Click += _btnLinkFormEnter_Click;
            // 
            // _btnEnd
            // 
            _btnEnd.BackColor = SystemColors.ButtonHighlight;
            _btnEnd.BackgroundImageLayout = ImageLayout.None;
            _btnEnd.Font = new Font("Calibri", 18F, FontStyle.Bold);
            _btnEnd.Location = new Point(1014, 436);
            _btnEnd.Name = "_btnEnd";
            _btnEnd.Size = new Size(281, 132);
            _btnEnd.TabIndex = 3;
            _btnEnd.Text = "EXIT";
            _btnEnd.UseVisualStyleBackColor = false;
            _btnEnd.Click += _btnEnd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(242, 313);
            label1.Name = "label1";
            label1.Size = new Size(936, 44);
            label1.TabIndex = 4;
            label1.Text = "POMOCÍ ČEHO VÁM MŮŽEME POMOCT OVĚŘIT INFORMACE?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1286, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1460, 662);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(_btnEnd);
            Controls.Add(_btnLinkFormEnter);
            Controls.Add(_btnTextFormEnter);
            Controls.Add(_lblWelcomeText);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lblWelcomeText;
        private Button _btnTextFormEnter;
        private Button _btnLinkFormEnter;
        private Button _btnEnd;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
namespace Gru
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAlza = new Button();
            btnAbbassa = new Button();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAlza
            // 
            btnAlza.Location = new Point(78, 237);
            btnAlza.Name = "btnAlza";
            btnAlza.Size = new Size(89, 68);
            btnAlza.TabIndex = 0;
            btnAlza.Text = "Alza";
            btnAlza.UseVisualStyleBackColor = true;
            btnAlza.Click += button1_Click;
            // 
            // btnAbbassa
            // 
            btnAbbassa.Location = new Point(78, 311);
            btnAbbassa.Name = "btnAbbassa";
            btnAbbassa.Size = new Size(89, 68);
            btnAbbassa.TabIndex = 0;
            btnAbbassa.Text = "Abbassa";
            btnAbbassa.UseVisualStyleBackColor = true;
            btnAbbassa.Click += btnAbbassa_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(173, 279);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(89, 68);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(483, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnReset);
            Controls.Add(btnAbbassa);
            Controls.Add(btnAlza);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlza;
        private Button btnAbbassa;
        private Button btnReset;
        private PictureBox pictureBox1;
    }
}

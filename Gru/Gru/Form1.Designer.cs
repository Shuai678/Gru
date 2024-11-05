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
            buttonUp = new Button();
            buttonDown = new Button();
            buttonReset = new Button();
            textBoxHMin = new TextBox();
            textBoxHMax = new TextBox();
            buttonApplica = new Button();
            gancio_img = new PictureBox();
            labelH_fissa = new Label();
            label_Hgancio = new Label();
            labelhmin_fissa = new Label();
            labelhmax_fissa = new Label();
            ((System.ComponentModel.ISupportInitialize)gancio_img).BeginInit();
            SuspendLayout();
            // 
            // buttonUp
            // 
            buttonUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUp.Location = new Point(49, 428);
            buttonUp.Margin = new Padding(4, 5, 4, 5);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(181, 80);
            buttonUp.TabIndex = 0;
            buttonUp.Text = "ALZA";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDown.Location = new Point(49, 572);
            buttonDown.Margin = new Padding(4, 5, 4, 5);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(181, 80);
            buttonDown.TabIndex = 1;
            buttonDown.Text = "ABBASSA";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.IndianRed;
            buttonReset.Location = new Point(261, 513);
            buttonReset.Margin = new Padding(4, 5, 4, 5);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(124, 63);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // textBoxHMin
            // 
            textBoxHMin.Location = new Point(49, 67);
            textBoxHMin.Margin = new Padding(4, 5, 4, 5);
            textBoxHMin.Name = "textBoxHMin";
            textBoxHMin.Size = new Size(180, 31);
            textBoxHMin.TabIndex = 3;
            // 
            // textBoxHMax
            // 
            textBoxHMax.Location = new Point(49, 143);
            textBoxHMax.Margin = new Padding(4, 5, 4, 5);
            textBoxHMax.Name = "textBoxHMax";
            textBoxHMax.Size = new Size(180, 31);
            textBoxHMax.TabIndex = 4;
            // 
            // buttonApplica
            // 
            buttonApplica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApplica.ForeColor = Color.ForestGreen;
            buttonApplica.Location = new Point(49, 208);
            buttonApplica.Margin = new Padding(4, 5, 4, 5);
            buttonApplica.Name = "buttonApplica";
            buttonApplica.Size = new Size(181, 48);
            buttonApplica.TabIndex = 5;
            buttonApplica.Text = "Applica";
            buttonApplica.UseVisualStyleBackColor = true;
            buttonApplica.Click += buttonApplica_Click;
            // 
            // gancio_img
            // 
            gancio_img.Image = (Image)resources.GetObject("gancio_img.Image");
            gancio_img.Location = new Point(736, 234);
            gancio_img.Margin = new Padding(4, 5, 4, 5);
            gancio_img.Name = "gancio_img";
            gancio_img.Size = new Size(143, 780);
            gancio_img.SizeMode = PictureBoxSizeMode.StretchImage;
            gancio_img.TabIndex = 10;
            gancio_img.TabStop = false;
            // 
            // labelH_fissa
            // 
            labelH_fissa.AutoSize = true;
            labelH_fissa.Location = new Point(49, 737);
            labelH_fissa.Margin = new Padding(4, 0, 4, 0);
            labelH_fissa.Name = "labelH_fissa";
            labelH_fissa.Size = new Size(162, 25);
            labelH_fissa.TabIndex = 11;
            labelH_fissa.Text = "Altezza Gancio (m):";
            // 
            // label_Hgancio
            // 
            label_Hgancio.AutoSize = true;
            label_Hgancio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Hgancio.Location = new Point(213, 737);
            label_Hgancio.Margin = new Padding(4, 0, 4, 0);
            label_Hgancio.Name = "label_Hgancio";
            label_Hgancio.Size = new Size(0, 25);
            label_Hgancio.TabIndex = 12;
            // 
            // labelhmin_fissa
            // 
            labelhmin_fissa.AutoSize = true;
            labelhmin_fissa.Location = new Point(247, 73);
            labelhmin_fissa.Margin = new Padding(4, 0, 4, 0);
            labelhmin_fissa.Name = "labelhmin_fissa";
            labelhmin_fissa.Size = new Size(305, 25);
            labelhmin_fissa.TabIndex = 14;
            labelhmin_fissa.Text = "Altezza min. piano di camapagna (m)";
            // 
            // labelhmax_fissa
            // 
            labelhmax_fissa.AutoSize = true;
            labelhmax_fissa.Location = new Point(247, 157);
            labelhmax_fissa.Margin = new Padding(4, 0, 4, 0);
            labelhmax_fissa.Name = "labelhmax_fissa";
            labelhmax_fissa.Size = new Size(137, 25);
            labelhmax_fissa.TabIndex = 15;
            labelhmax_fissa.Text = "Altezza max (m)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1550, 1225);
            Controls.Add(labelhmax_fissa);
            Controls.Add(labelhmin_fissa);
            Controls.Add(label_Hgancio);
            Controls.Add(labelH_fissa);
            Controls.Add(gancio_img);
            Controls.Add(buttonApplica);
            Controls.Add(textBoxHMax);
            Controls.Add(textBoxHMin);
            Controls.Add(buttonReset);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Simulatore Gru";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gancio_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUp;
        private Button buttonDown;
        private Button buttonReset;
        private TextBox textBoxHMin;
        private TextBox textBoxHMax;
        private Button buttonApplica;
        private PictureBox gancio_img;
        private Label labelH_fissa;
        private Label label_Hgancio;
        private Label labelhmin_fissa;
        private Label labelhmax_fissa;
    }
}

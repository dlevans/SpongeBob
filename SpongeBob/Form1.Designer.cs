namespace SpongeBob
{
    partial class Form1
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
            this.rvrse = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.Button();
            this.minoy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rvrse
            // 
            this.rvrse.Location = new System.Drawing.Point(12, 74);
            this.rvrse.Name = "rvrse";
            this.rvrse.Size = new System.Drawing.Size(75, 23);
            this.rvrse.TabIndex = 0;
            this.rvrse.Text = "Reverse";
            this.rvrse.UseVisualStyleBackColor = true;
            this.rvrse.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 25);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(237, 20);
            this.inputText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter text:";
            // 
            // man
            // 
            this.man.Location = new System.Drawing.Point(93, 74);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(75, 23);
            this.man.TabIndex = 3;
            this.man.Text = "mAnIpuLate";
            this.man.UseVisualStyleBackColor = true;
            this.man.Click += new System.EventHandler(this.button2_Click);
            // 
            // minoy
            // 
            this.minoy.Location = new System.Drawing.Point(174, 74);
            this.minoy.Name = "minoy";
            this.minoy.Size = new System.Drawing.Size(75, 23);
            this.minoy.TabIndex = 4;
            this.minoy.Text = "minoy";
            this.minoy.UseVisualStyleBackColor = true;
            this.minoy.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SpongeBob.Properties.Resources.spongebob;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(286, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(15, 255);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(234, 20);
            this.outputText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpongeBob.Properties.Resources.bikinibottom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 311);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minoy);
            this.Controls.Add(this.man);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.rvrse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SpongeBob";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rvrse;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button man;
        private System.Windows.Forms.Button minoy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox outputText;
    }
}


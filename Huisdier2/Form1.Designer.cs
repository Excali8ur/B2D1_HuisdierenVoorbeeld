namespace Huisdier2
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
            this.btnSchildpad = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnCavia = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnEten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSchildpad
            // 
            this.btnSchildpad.Location = new System.Drawing.Point(12, 50);
            this.btnSchildpad.Name = "btnSchildpad";
            this.btnSchildpad.Size = new System.Drawing.Size(75, 23);
            this.btnSchildpad.TabIndex = 0;
            this.btnSchildpad.Text = "Schildpad";
            this.btnSchildpad.UseVisualStyleBackColor = true;
            this.btnSchildpad.Click += new System.EventHandler(this.btnSchildpad_Click);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(13, 13);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 1;
            this.tbNaam.Text = "Naam";
            // 
            // btnCavia
            // 
            this.btnCavia.Location = new System.Drawing.Point(94, 50);
            this.btnCavia.Name = "btnCavia";
            this.btnCavia.Size = new System.Drawing.Size(75, 23);
            this.btnCavia.TabIndex = 2;
            this.btnCavia.Text = "Cavia";
            this.btnCavia.UseVisualStyleBackColor = true;
            this.btnCavia.Click += new System.EventHandler(this.btnCavia_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(225, 10);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(62, 20);
            this.tbX.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "y :";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(226, 30);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(61, 20);
            this.tbY.TabIndex = 5;
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(367, 33);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(75, 23);
            this.btnEten.TabIndex = 7;
            this.btnEten.Text = "Eten!";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 388);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnCavia);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.btnSchildpad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchildpad;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnCavia;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


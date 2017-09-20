namespace B2D1_RobotStratenplan
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
            this.btnVoorwaarts = new System.Windows.Forms.Button();
            this.btnDraai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoorwaarts
            // 
            this.btnVoorwaarts.Location = new System.Drawing.Point(12, 12);
            this.btnVoorwaarts.Name = "btnVoorwaarts";
            this.btnVoorwaarts.Size = new System.Drawing.Size(91, 23);
            this.btnVoorwaarts.TabIndex = 0;
            this.btnVoorwaarts.Text = "Voorwaarts";
            this.btnVoorwaarts.UseVisualStyleBackColor = true;
            this.btnVoorwaarts.Click += new System.EventHandler(this.btnVoorwaarts_Click);
            // 
            // btnDraai
            // 
            this.btnDraai.Location = new System.Drawing.Point(109, 12);
            this.btnDraai.Name = "btnDraai";
            this.btnDraai.Size = new System.Drawing.Size(91, 23);
            this.btnDraai.TabIndex = 1;
            this.btnDraai.Text = "Draai LinksOm";
            this.btnDraai.UseVisualStyleBackColor = true;
            this.btnDraai.Click += new System.EventHandler(this.btnDraai_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 441);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDraai);
            this.Controls.Add(this.btnVoorwaarts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoorwaarts;
        private System.Windows.Forms.Button btnDraai;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


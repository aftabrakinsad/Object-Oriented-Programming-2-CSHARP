
namespace TheFOOLGAME
{
    partial class mainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm1));
            this.Quelabel1 = new System.Windows.Forms.Label();
            this.yesbutton1 = new System.Windows.Forms.Button();
            this.nobutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quelabel1
            // 
            this.Quelabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quelabel1.Location = new System.Drawing.Point(234, 146);
            this.Quelabel1.Name = "Quelabel1";
            this.Quelabel1.Size = new System.Drawing.Size(345, 50);
            this.Quelabel1.TabIndex = 0;
            this.Quelabel1.Text = "Are you a fool?";
            this.Quelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesbutton1
            // 
            this.yesbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yesbutton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton1.ForeColor = System.Drawing.Color.White;
            this.yesbutton1.Location = new System.Drawing.Point(286, 224);
            this.yesbutton1.Name = "yesbutton1";
            this.yesbutton1.Size = new System.Drawing.Size(75, 33);
            this.yesbutton1.TabIndex = 1;
            this.yesbutton1.Text = "Yes";
            this.yesbutton1.UseVisualStyleBackColor = false;
            this.yesbutton1.Click += new System.EventHandler(this.yesbutton1_Click);
            // 
            // nobutton1
            // 
            this.nobutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nobutton1.ForeColor = System.Drawing.Color.White;
            this.nobutton1.Location = new System.Drawing.Point(437, 225);
            this.nobutton1.Name = "nobutton1";
            this.nobutton1.Size = new System.Drawing.Size(75, 33);
            this.nobutton1.TabIndex = 2;
            this.nobutton1.Text = "No";
            this.nobutton1.UseVisualStyleBackColor = false;
            this.nobutton1.MouseEnter += new System.EventHandler(this.nobutton1_mouseEnter);
            // 
            // mainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nobutton1);
            this.Controls.Add(this.yesbutton1);
            this.Controls.Add(this.Quelabel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The FOOL GAME";
            this.Load += new System.EventHandler(this.mainForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Quelabel1;
        private System.Windows.Forms.Button yesbutton1;
        private System.Windows.Forms.Button nobutton1;
    }
}


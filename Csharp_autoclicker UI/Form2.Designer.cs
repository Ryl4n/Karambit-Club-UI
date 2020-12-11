namespace Csharp_autoclicker_UI
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.skeetBackground1 = new SkeetFramework.SkeetBackground();
            this.skeetButton2 = new SkeetFramework.SkeetButton();
            this.skeetButton1 = new SkeetFramework.SkeetButton();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.skeetBackground1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skeetBackground1
            // 
            this.skeetBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetBackground1.Controls.Add(this.panel1);
            this.skeetBackground1.Controls.Add(this.skeetButton2);
            this.skeetBackground1.Controls.Add(this.skeetButton1);
            this.skeetBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skeetBackground1.Location = new System.Drawing.Point(0, 0);
            this.skeetBackground1.Name = "skeetBackground1";
            this.skeetBackground1.Size = new System.Drawing.Size(487, 310);
            this.skeetBackground1.TabIndex = 0;
            this.skeetBackground1.Text = "skeetBackground1";
            this.skeetBackground1.Click += new System.EventHandler(this.skeetBackground1_Click);
            // 
            // skeetButton2
            // 
            this.skeetButton2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton2.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton2.Location = new System.Drawing.Point(180, 103);
            this.skeetButton2.Name = "skeetButton2";
            this.skeetButton2.Size = new System.Drawing.Size(131, 47);
            this.skeetButton2.TabIndex = 1;
            this.skeetButton2.Text = "Access";
            this.skeetButton2.Click += new System.EventHandler(this.skeetButton2_Click);
            // 
            // skeetButton1
            // 
            this.skeetButton1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.skeetButton1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.skeetButton1.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetButton1.Location = new System.Drawing.Point(180, 156);
            this.skeetButton1.Name = "skeetButton1";
            this.skeetButton1.Size = new System.Drawing.Size(131, 47);
            this.skeetButton1.TabIndex = 0;
            this.skeetButton1.Text = "Copy HWID";
            this.skeetButton1.Click += new System.EventHandler(this.skeetButton1_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.skeetBackground1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 10);
            this.panel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 310);
            this.Controls.Add(this.skeetBackground1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.skeetBackground1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkeetFramework.SkeetBackground skeetBackground1;
        private SkeetFramework.SkeetButton skeetButton2;
        private SkeetFramework.SkeetButton skeetButton1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Panel panel1;
    }
}
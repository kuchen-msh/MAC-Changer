namespace MACChanger
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nMAC = new System.Windows.Forms.TextBox();
            this.cMAC = new System.Windows.Forms.Button();
            this.aMAC = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktuelle MAC:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neue MAC:";
            // 
            // nMAC
            // 
            this.nMAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMAC.Location = new System.Drawing.Point(39, 321);
            this.nMAC.Name = "nMAC";
            this.nMAC.Size = new System.Drawing.Size(205, 13);
            this.nMAC.TabIndex = 3;
            // 
            // cMAC
            // 
            this.cMAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cMAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cMAC.ForeColor = System.Drawing.Color.White;
            this.cMAC.Location = new System.Drawing.Point(165, 378);
            this.cMAC.Name = "cMAC";
            this.cMAC.Size = new System.Drawing.Size(103, 23);
            this.cMAC.TabIndex = 4;
            this.cMAC.Text = "Wechsel die MAC";
            this.cMAC.UseVisualStyleBackColor = false;
            this.cMAC.Click += new System.EventHandler(this.cMAC_Click);
            // 
            // aMAC
            // 
            this.aMAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aMAC.Location = new System.Drawing.Point(43, 271);
            this.aMAC.Name = "aMAC";
            this.aMAC.Size = new System.Drawing.Size(201, 13);
            this.aMAC.TabIndex = 5;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.Green;
            this.State.Location = new System.Drawing.Point(43, 337);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(43, 15);
            this.State.TabIndex = 6;
            this.State.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 21);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "MAC Changer by UnknownCPP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 212);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(280, 413);
            this.Controls.Add(this.cMAC);
            this.Controls.Add(this.State);
            this.Controls.Add(this.nMAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aMAC);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MACChanger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nMAC;
        private System.Windows.Forms.Button cMAC;
        private System.Windows.Forms.TextBox aMAC;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}


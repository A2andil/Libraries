namespace ConvertBackgroundIntoFrames
{
    partial class BackgroundFrames
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
            this.btnCls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSlctPath = new System.Windows.Forms.Button();
            this.btnSlctFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCls
            // 
            this.btnCls.BackColor = System.Drawing.Color.White;
            this.btnCls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCls.FlatAppearance.BorderSize = 0;
            this.btnCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCls.ForeColor = System.Drawing.Color.Red;
            this.btnCls.Location = new System.Drawing.Point(465, 0);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(35, 35);
            this.btnCls.TabIndex = 0;
            this.btnCls.Text = "X";
            this.btnCls.UseVisualStyleBackColor = false;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Background:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 80);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(429, 31);
            this.txtPath.TabIndex = 2;
            // 
            // btnSlctPath
            // 
            this.btnSlctPath.BackColor = System.Drawing.Color.White;
            this.btnSlctPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlctPath.FlatAppearance.BorderSize = 0;
            this.btnSlctPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlctPath.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlctPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSlctPath.Location = new System.Drawing.Point(444, 80);
            this.btnSlctPath.Name = "btnSlctPath";
            this.btnSlctPath.Size = new System.Drawing.Size(53, 30);
            this.btnSlctPath.TabIndex = 3;
            this.btnSlctPath.Text = "...";
            this.btnSlctPath.UseVisualStyleBackColor = false;
            this.btnSlctPath.Click += new System.EventHandler(this.btnSlctPath_Click);
            // 
            // btnSlctFolder
            // 
            this.btnSlctFolder.BackColor = System.Drawing.Color.White;
            this.btnSlctFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlctFolder.FlatAppearance.BorderSize = 0;
            this.btnSlctFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlctFolder.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlctFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSlctFolder.Location = new System.Drawing.Point(444, 157);
            this.btnSlctFolder.Name = "btnSlctFolder";
            this.btnSlctFolder.Size = new System.Drawing.Size(53, 30);
            this.btnSlctFolder.TabIndex = 6;
            this.btnSlctFolder.Text = "...";
            this.btnSlctFolder.UseVisualStyleBackColor = false;
            this.btnSlctFolder.Click += new System.EventHandler(this.btnSlctFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(12, 157);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(429, 31);
            this.txtFolder.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path To Save:";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(52, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(378, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Process and Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BackgroundFrames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 257);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSlctFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSlctPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCls);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "BackgroundFrames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSlctPath;
        private System.Windows.Forms.Button btnSlctFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}


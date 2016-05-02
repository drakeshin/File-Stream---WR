namespace File_Stream___WR
{
    partial class FSWR
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileLocal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.readBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowserFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.typeFile = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.convertBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // fileLocal
            // 
            this.fileLocal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fileLocal.Location = new System.Drawing.Point(47, 22);
            this.fileLocal.Name = "fileLocal";
            this.fileLocal.ReadOnly = true;
            this.fileLocal.Size = new System.Drawing.Size(434, 20);
            this.fileLocal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(495, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Content:";
            // 
            // readBox
            // 
            this.readBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readBox.Location = new System.Drawing.Point(47, 74);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.Size = new System.Drawing.Size(434, 302);
            this.readBox.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(495, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Read FileType:";
            // 
            // typeFile
            // 
            this.typeFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeFile.FormattingEnabled = true;
            this.typeFile.Items.AddRange(new object[] {
            "Text",
            "Hex",
            "Binary",
            "Base64"});
            this.typeFile.Location = new System.Drawing.Point(495, 198);
            this.typeFile.Name = "typeFile";
            this.typeFile.Size = new System.Drawing.Size(92, 21);
            this.typeFile.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(495, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // convertBt
            // 
            this.convertBt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.convertBt.Location = new System.Drawing.Point(495, 133);
            this.convertBt.Name = "convertBt";
            this.convertBt.Size = new System.Drawing.Size(84, 23);
            this.convertBt.TabIndex = 11;
            this.convertBt.Text = "Convert";
            this.convertBt.UseVisualStyleBackColor = true;
            this.convertBt.Click += new System.EventHandler(this.button4_Click);
            // 
            // FSWR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.convertBt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typeFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileLocal);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(610, 430);
            this.Name = "FSWR";
            this.Text = "File Stream - WR";
            this.Load += new System.EventHandler(this.FSWR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog BrowserFolder;
        private System.Windows.Forms.ComboBox typeFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button convertBt;
    }
}


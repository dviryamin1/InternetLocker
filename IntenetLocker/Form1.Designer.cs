namespace InternetLocker
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
            this.enableBtn = new System.Windows.Forms.Button();
            this.disableBtn = new System.Windows.Forms.Button();
            this.enAllBtn = new System.Windows.Forms.Button();
            this.disAllBtn = new System.Windows.Forms.Button();
            this.interfacesList = new System.Windows.Forms.CheckedListBox();
            this.cmd = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // enableBtn
            // 
            this.enableBtn.Location = new System.Drawing.Point(12, 219);
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(187, 42);
            this.enableBtn.TabIndex = 0;
            this.enableBtn.Text = "Enable Internet connection";
            this.enableBtn.UseVisualStyleBackColor = true;
            this.enableBtn.Click += new System.EventHandler(this.enableBtn_Click);
            // 
            // disableBtn
            // 
            this.disableBtn.Location = new System.Drawing.Point(366, 219);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(187, 42);
            this.disableBtn.TabIndex = 1;
            this.disableBtn.Text = "Disable Internet connection";
            this.disableBtn.UseVisualStyleBackColor = true;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // enAllBtn
            // 
            this.enAllBtn.Location = new System.Drawing.Point(12, 157);
            this.enAllBtn.Name = "enAllBtn";
            this.enAllBtn.Size = new System.Drawing.Size(187, 42);
            this.enAllBtn.TabIndex = 2;
            this.enAllBtn.Text = "Enable All Internet connection";
            this.enAllBtn.UseVisualStyleBackColor = true;
            this.enAllBtn.Click += new System.EventHandler(this.enAllBtn_Click);
            // 
            // disAllBtn
            // 
            this.disAllBtn.Location = new System.Drawing.Point(366, 157);
            this.disAllBtn.Name = "disAllBtn";
            this.disAllBtn.Size = new System.Drawing.Size(187, 42);
            this.disAllBtn.TabIndex = 3;
            this.disAllBtn.Text = "Disable All Internet connection";
            this.disAllBtn.UseVisualStyleBackColor = true;
            this.disAllBtn.Click += new System.EventHandler(this.disAllBtn_Click);
            // 
            // interfacesList
            // 
            this.interfacesList.FormattingEnabled = true;
            this.interfacesList.HorizontalScrollbar = true;
            this.interfacesList.Location = new System.Drawing.Point(12, 12);
            this.interfacesList.Name = "interfacesList";
            this.interfacesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interfacesList.Size = new System.Drawing.Size(224, 109);
            this.interfacesList.TabIndex = 4;
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(350, 56);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(119, 17);
            this.cmd.TabIndex = 6;
            this.cmd.Text = "Show CMD window";
            this.cmd.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(346, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 273);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.interfacesList);
            this.Controls.Add(this.disAllBtn);
            this.Controls.Add(this.enAllBtn);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.enableBtn);
            this.Name = "Form1";
            this.Text = "Internet Locker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableBtn;
        private System.Windows.Forms.Button disableBtn;
        private System.Windows.Forms.Button enAllBtn;
        private System.Windows.Forms.Button disAllBtn;
        private System.Windows.Forms.CheckedListBox interfacesList;
        private System.Windows.Forms.CheckBox cmd;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


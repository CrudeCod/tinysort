namespace tinysort
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCheck = new System.Windows.Forms.CheckBox();
            this.imgCheck = new System.Windows.Forms.CheckBox();
            this.appCheck = new System.Windows.Forms.CheckBox();
            this.vidCheck = new System.Windows.Forms.CheckBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.directoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tinysort 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCheck
            // 
            this.textCheck.AutoSize = true;
            this.textCheck.Location = new System.Drawing.Point(342, 32);
            this.textCheck.Name = "textCheck";
            this.textCheck.Size = new System.Drawing.Size(111, 21);
            this.textCheck.TabIndex = 1;
            this.textCheck.Text = "Sort text files";
            this.textCheck.UseVisualStyleBackColor = true;
            // 
            // imgCheck
            // 
            this.imgCheck.AutoSize = true;
            this.imgCheck.Location = new System.Drawing.Point(342, 97);
            this.imgCheck.Name = "imgCheck";
            this.imgCheck.Size = new System.Drawing.Size(105, 21);
            this.imgCheck.TabIndex = 2;
            this.imgCheck.Text = "Sort images";
            this.imgCheck.UseVisualStyleBackColor = true;
            // 
            // appCheck
            // 
            this.appCheck.AutoSize = true;
            this.appCheck.Location = new System.Drawing.Point(342, 165);
            this.appCheck.Name = "appCheck";
            this.appCheck.Size = new System.Drawing.Size(135, 21);
            this.appCheck.TabIndex = 3;
            this.appCheck.Text = "Sort applications";
            this.appCheck.UseVisualStyleBackColor = true;
            // 
            // vidCheck
            // 
            this.vidCheck.AutoSize = true;
            this.vidCheck.Location = new System.Drawing.Point(342, 234);
            this.vidCheck.Name = "vidCheck";
            this.vidCheck.Size = new System.Drawing.Size(101, 21);
            this.vidCheck.TabIndex = 4;
            this.vidCheck.Text = "Sort videos";
            this.vidCheck.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(130, 229);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(192, 26);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "sort the directory";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(33, 229);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(75, 25);
            this.directoryButton.TabIndex = 6;
            this.directoryButton.Text = "path";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 289);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.vidCheck);
            this.Controls.Add(this.appCheck);
            this.Controls.Add(this.imgCheck);
            this.Controls.Add(this.textCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox textCheck;
        private System.Windows.Forms.CheckBox imgCheck;
        private System.Windows.Forms.CheckBox appCheck;
        private System.Windows.Forms.CheckBox vidCheck;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button directoryButton;
    }
}


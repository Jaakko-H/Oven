namespace Subject
{
    partial class Oven
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
            this.btnSetTemp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStartHeating = new System.Windows.Forms.Button();
            this.btnAddPush = new System.Windows.Forms.Button();
            this.btnAddPull = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetTemp
            // 
            this.btnSetTemp.Location = new System.Drawing.Point(21, 12);
            this.btnSetTemp.Name = "btnSetTemp";
            this.btnSetTemp.Size = new System.Drawing.Size(100, 42);
            this.btnSetTemp.TabIndex = 0;
            this.btnSetTemp.Text = " Set Desired Temperature";
            this.btnSetTemp.UseVisualStyleBackColor = true;
            this.btnSetTemp.Click += new System.EventHandler(this.btnSetTemp_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // btnStartHeating
            // 
            this.btnStartHeating.Location = new System.Drawing.Point(21, 60);
            this.btnStartHeating.Name = "btnStartHeating";
            this.btnStartHeating.Size = new System.Drawing.Size(100, 23);
            this.btnStartHeating.TabIndex = 2;
            this.btnStartHeating.Text = " Start heating";
            this.btnStartHeating.UseVisualStyleBackColor = true;
            this.btnStartHeating.Click += new System.EventHandler(this.btnStartHeating_Click_1);
            // 
            // btnAddPush
            // 
            this.btnAddPush.Location = new System.Drawing.Point(21, 120);
            this.btnAddPush.Name = "btnAddPush";
            this.btnAddPush.Size = new System.Drawing.Size(119, 42);
            this.btnAddPush.TabIndex = 5;
            this.btnAddPush.Text = "Start a New Push-Observer";
            this.btnAddPush.UseVisualStyleBackColor = true;
            this.btnAddPush.Click += new System.EventHandler(this.btnAddPush_Click_1);
            // 
            // btnAddPull
            // 
            this.btnAddPull.Location = new System.Drawing.Point(153, 120);
            this.btnAddPull.Name = "btnAddPull";
            this.btnAddPull.Size = new System.Drawing.Size(119, 42);
            this.btnAddPull.TabIndex = 6;
            this.btnAddPull.Text = "Start a New Pull-Observer";
            this.btnAddPull.UseVisualStyleBackColor = true;
            this.btnAddPull.Click += new System.EventHandler(this.btnAddPull_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Oven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPull);
            this.Controls.Add(this.btnAddPush);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartHeating);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSetTemp);
            this.Name = "Oven";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetTemp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartHeating;
        private System.Windows.Forms.Button btnAddPush;
        private System.Windows.Forms.Button btnAddPull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}


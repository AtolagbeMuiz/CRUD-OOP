namespace CRUD_OOP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOBILE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADDRESS";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(65, 25);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(156, 20);
            this.Name.TabIndex = 5;
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(65, 58);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(119, 20);
            this.Mobile.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(65, 97);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(146, 20);
            this.Address.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(41, 148);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(136, 148);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 12;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            //this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(232, 148);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            //this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}
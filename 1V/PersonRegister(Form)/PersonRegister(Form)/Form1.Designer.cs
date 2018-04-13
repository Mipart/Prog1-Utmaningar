namespace PersonRegister_Form_
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
            this.btn_del = new System.Windows.Forms.Button();
            this.cb_nameBox = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_town = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(25, 130);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(115, 23);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Remove";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // cb_nameBox
            // 
            this.cb_nameBox.FormattingEnabled = true;
            this.cb_nameBox.Location = new System.Drawing.Point(13, 13);
            this.cb_nameBox.Name = "cb_nameBox";
            this.cb_nameBox.Size = new System.Drawing.Size(121, 24);
            this.cb_nameBox.TabIndex = 2;
            this.cb_nameBox.SelectedIndexChanged += new System.EventHandler(this.cb_nameBox_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(25, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 3;
            this.txt_name.Text = "Namn";
            // 
            // txt_town
            // 
            this.txt_town.Location = new System.Drawing.Point(25, 73);
            this.txt_town.Name = "txt_town";
            this.txt_town.Size = new System.Drawing.Size(100, 22);
            this.txt_town.TabIndex = 4;
            this.txt_town.Text = "Stad";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(25, 102);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 22);
            this.txt_age.TabIndex = 5;
            this.txt_age.Text = "Ålder";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(25, 159);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(115, 23);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "Create New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 192);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_town);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cb_nameBox);
            this.Controls.Add(this.btn_del);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox cb_nameBox;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_town;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_new;
    }
}


namespace Recipe_Manager
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
            this.btn_addRecipe = new System.Windows.Forms.Button();
            this.btn_removeRecipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addRecipe
            // 
            this.btn_addRecipe.Location = new System.Drawing.Point(55, 72);
            this.btn_addRecipe.Name = "btn_addRecipe";
            this.btn_addRecipe.Size = new System.Drawing.Size(127, 64);
            this.btn_addRecipe.TabIndex = 0;
            this.btn_addRecipe.Text = "Add Recipe";
            this.btn_addRecipe.UseVisualStyleBackColor = true;
            // 
            // btn_removeRecipe
            // 
            this.btn_removeRecipe.Location = new System.Drawing.Point(206, 72);
            this.btn_removeRecipe.Name = "btn_removeRecipe";
            this.btn_removeRecipe.Size = new System.Drawing.Size(122, 64);
            this.btn_removeRecipe.TabIndex = 1;
            this.btn_removeRecipe.Text = "Remove Recipe";
            this.btn_removeRecipe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recipe Manager";
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(12, 142);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(351, 211);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removeRecipe);
            this.Controls.Add(this.btn_addRecipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addRecipe;
        private System.Windows.Forms.Button btn_removeRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Button button1;
    }
}


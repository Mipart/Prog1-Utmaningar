namespace Recipe_Manager
{
    partial class AddRecipe
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
            this.tb_recipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ingre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_inst = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name :";
            // 
            // tb_recipeName
            // 
            this.tb_recipeName.Location = new System.Drawing.Point(119, 59);
            this.tb_recipeName.Name = "tb_recipeName";
            this.tb_recipeName.Size = new System.Drawing.Size(100, 22);
            this.tb_recipeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Recipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredients";
            // 
            // tb_ingre
            // 
            this.tb_ingre.Location = new System.Drawing.Point(15, 125);
            this.tb_ingre.Name = "tb_ingre";
            this.tb_ingre.Size = new System.Drawing.Size(204, 22);
            this.tb_ingre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instructions:";
            // 
            // rtb_inst
            // 
            this.rtb_inst.Location = new System.Drawing.Point(12, 196);
            this.rtb_inst.Name = "rtb_inst";
            this.rtb_inst.Size = new System.Drawing.Size(192, 96);
            this.rtb_inst.TabIndex = 6;
            this.rtb_inst.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 298);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(119, 298);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(75, 23);
            this.btn_can.TabIndex = 8;
            this.btn_can.Text = "Cancel";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 343);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtb_inst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ingre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_recipeName);
            this.Controls.Add(this.label1);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_recipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ingre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_inst;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_can;
    }
}
namespace Armoring
{
    partial class Armoring
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_countdays = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_countchild = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_armor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(271, 75);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 0;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(271, 117);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_surname.TabIndex = 1;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(271, 161);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(100, 20);
            this.tb_lastname.TabIndex = 2;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(271, 207);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(100, 20);
            this.tb_Phone.TabIndex = 3;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(271, 254);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 4;
            // 
            // tb_countdays
            // 
            this.tb_countdays.Location = new System.Drawing.Point(271, 297);
            this.tb_countdays.Name = "tb_countdays";
            this.tb_countdays.Size = new System.Drawing.Size(100, 20);
            this.tb_countdays.TabIndex = 5;
            this.tb_countdays.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(218, 75);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(29, 13);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Паспорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кол-во дней";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во детей";
            // 
            // tb_countchild
            // 
            this.tb_countchild.Location = new System.Drawing.Point(271, 340);
            this.tb_countchild.Name = "tb_countchild";
            this.tb_countchild.Size = new System.Drawing.Size(100, 20);
            this.tb_countchild.TabIndex = 12;
            this.tb_countchild.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // btn_armor
            // 
            this.btn_armor.Location = new System.Drawing.Point(12, 282);
            this.btn_armor.Name = "btn_armor";
            this.btn_armor.Size = new System.Drawing.Size(143, 96);
            this.btn_armor.TabIndex = 15;
            this.btn_armor.Text = "ARMOR";
            this.btn_armor.UseVisualStyleBackColor = true;
            this.btn_armor.Click += new System.EventHandler(this.btn_armor_Click);
            // 
            // Armoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_armor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_countchild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_countdays);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Name = "Armoring";
            this.Text = "Armoring";
            this.Load += new System.EventHandler(this.Armoring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_countdays;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_countchild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_armor;
    }
}
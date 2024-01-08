namespace Dönem_Projesi
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1115, 386);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Barınak Ekle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(774, 167);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(747, 106);
            button3.Name = "button3";
            button3.Size = new Size(151, 40);
            button3.TabIndex = 12;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(686, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 31);
            comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(601, 43);
            label5.Name = "label5";
            label5.Size = new Size(441, 31);
            label5.TabIndex = 10;
            label5.Text = "Son Eklenen Barınakların ID numaraları:\r\n";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(294, 63);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 30);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 66);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 8;
            label4.Text = "Barınak ID:";
            // 
            // button2
            // 
            button2.Location = new Point(747, 259);
            button2.Name = "button2";
            button2.Size = new Size(151, 41);
            button2.TabIndex = 7;
            button2.Text = "Barınak Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(162, 288);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 6;
            button1.Text = "Barinak Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 30);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 30);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 216);
            label3.Name = "label3";
            label3.Size = new Size(136, 46);
            label3.TabIndex = 3;
            label3.Text = "Barınak \r\nBüyüklüğü(m²):\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 171);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 2;
            label2.Text = "Barınak Adresi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 119);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Barınak Adi:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1153, 627);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button3;
        private Label label6;
    }
}
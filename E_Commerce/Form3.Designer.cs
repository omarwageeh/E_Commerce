namespace E_Commerce
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            button7 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(25, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(350, 318);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(342, 290);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(16, 202);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Category", "Price", "Name" });
            comboBox1.Location = new Point(169, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 94);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Filter By";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(342, 290);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Orders";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 116);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 22;
            label3.Text = "OrderId";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 20;
            label2.Text = "ProductId";
            // 
            // button7
            // 
            button7.Location = new Point(198, 6);
            button7.Name = "button7";
            button7.Size = new Size(93, 23);
            button7.TabIndex = 19;
            button7.Text = "List Orders";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 18;
            // 
            // button5
            // 
            button5.Location = new Point(47, 230);
            button5.Name = "button5";
            button5.Size = new Size(93, 23);
            button5.TabIndex = 16;
            button5.Text = "Place Order";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(156, 186);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 1;
            button4.Text = "Remove Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(47, 186);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 0;
            button3.Text = "Add Product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(392, 294);
            dataGridView1.TabIndex = 15;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            Name = "Form3";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button7;
        private TextBox textBox2;
        private Button button6;
        private Button button5;
        private TextBox textBox3;
        private Label label3;
    }
}
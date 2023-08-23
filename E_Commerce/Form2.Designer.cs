namespace E_Commerce
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button4 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            dataContextBindingSource1 = new BindingSource(components);
            dataContextBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(454, 371);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(446, 343);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product Control";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(188, 252);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(269, 252);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Remove";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(107, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(107, 206);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 206);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 165);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 7;
            label4.Text = "Unit in Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "UnitPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "NameAr";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "NameEn";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(107, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(446, 343);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Category Control";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(260, 85);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(98, 85);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 42);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(73, 42);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 0;
            // 
            // dataContextBindingSource1
            // 
            dataContextBindingSource1.DataSource = typeof(Data.Context.DataContext);
            // 
            // dataContextBindingSource
            // 
            dataContextBindingSource.DataSource = typeof(Data.Context.DataContext);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(509, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(392, 343);
            dataGridView1.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 489);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "AdminForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private Button button1;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Button button4;
        private Button button2;
        private Button button5;
        private BindingSource dataContextBindingSource;
        private BindingSource dataContextBindingSource1;
        private Button button3;
        private ListView listView1;
        private DataGridView dataGridView1;
    }
}
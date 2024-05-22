//Form1.Designer.cs
using System.Resources;

namespace lab2tochno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_list = new Label();
            button_swap = new Button();
            button_add = new Button();
            button_delete = new Button();
            button4 = new Button();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label_list
            // 
            label_list.AutoSize = true;
            label_list.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_list.Location = new Point(2, 0);
            label_list.Margin = new Padding(2, 0, 2, 0);
            label_list.Name = "label_list";
            label_list.Size = new Size(0, 29);
            label_list.TabIndex = 0;
            // 
            // button_swap
            // 
            button_swap.BackColor = SystemColors.ControlLight;
            button_swap.Location = new Point(28, 345);
            button_swap.Margin = new Padding(3, 4, 3, 4);
            button_swap.Name = "button_swap";
            button_swap.Size = new Size(142, 82);
            button_swap.TabIndex = 2;
            button_swap.Text = "Поиск";
            button_swap.UseVisualStyleBackColor = false;
            button_swap.Click += button_swap_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(488, 345);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(142, 82);
            button_add.TabIndex = 4;
            button_add.Text = "Сохранить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(746, 345);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(142, 82);
            button_delete.TabIndex = 7;
            button_delete.Text = "Удалить";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button4
            // 
            button4.Location = new Point(286, 345);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(142, 82);
            button4.TabIndex = 0;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label_list);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(488, 77);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 260);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 68);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 260);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 27);
            textBox2.TabIndex = 10;
            textBox2.Text = "Введите текст:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(488, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 27);
            textBox3.TabIndex = 11;
            textBox3.Text = "Список чисел:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(28, 455);
            button1.Name = "button1";
            button1.Size = new Size(132, 97);
            button1.TabIndex = 12;
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(176, 455);
            button2.Name = "button2";
            button2.Size = new Size(132, 97);
            button2.TabIndex = 13;
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 574);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(455, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(numericUpDown1);
            Controls.Add(button_add);
            Controls.Add(button4);
            Controls.Add(button_delete);
            Controls.Add(button_swap);
            ForeColor = Color.DarkBlue;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "SearchingForNumbers_";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_list;
        private Button button_swap;
        private Button button_add;
        private Button button_delete;
        private Button button4;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
    }
}
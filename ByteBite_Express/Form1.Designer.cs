namespace ByteBite_Express
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
            panel1 = new Panel();
            panel3 = new Panel();
            categoryBtn2 = new Button();
            categoryBtn1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(245, 238, 224);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 446);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(219, 196, 165);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(categoryBtn2);
            panel3.Controls.Add(categoryBtn1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-2, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(129, 355);
            panel3.TabIndex = 1;
            // 
            // categoryBtn2
            // 
            categoryBtn2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryBtn2.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn2.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn2.Location = new Point(5, 98);
            categoryBtn2.Name = "categoryBtn2";
            categoryBtn2.Padding = new Padding(5, 0, 0, 0);
            categoryBtn2.Size = new Size(121, 30);
            categoryBtn2.TabIndex = 2;
            categoryBtn2.Text = "Coffee";
            categoryBtn2.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn2.UseVisualStyleBackColor = true;
            categoryBtn2.Click += button2_Click;
            // 
            // categoryBtn1
            // 
            categoryBtn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryBtn1.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn1.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn1.Location = new Point(5, 62);
            categoryBtn1.Name = "categoryBtn1";
            categoryBtn1.Padding = new Padding(5, 0, 0, 0);
            categoryBtn1.Size = new Size(121, 30);
            categoryBtn1.TabIndex = 1;
            categoryBtn1.Text = "Top Picks";
            categoryBtn1.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 36, 29);
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(250, 246, 238);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 88);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Bahnschrift SemiCondensed", 10F);
            button1.ForeColor = Color.FromArgb(176, 60, 60);
            button1.Location = new Point(5, 132);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(121, 30);
            button1.TabIndex = 3;
            button1.Text = "Pantries";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Bahnschrift SemiCondensed", 10F);
            button2.ForeColor = Color.FromArgb(176, 60, 60);
            button2.Location = new Point(5, 168);
            button2.Name = "button2";
            button2.Padding = new Padding(5, 0, 0, 0);
            button2.Size = new Size(121, 29);
            button2.TabIndex = 4;
            button2.Text = "Main Dish";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Bahnschrift SemiCondensed", 10F);
            button3.ForeColor = Color.FromArgb(176, 60, 60);
            button3.Location = new Point(5, 203);
            button3.Name = "button3";
            button3.Padding = new Padding(5, 0, 0, 0);
            button3.Size = new Size(121, 33);
            button3.TabIndex = 5;
            button3.Text = "Side Dish";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Bahnschrift SemiCondensed", 10F);
            button4.ForeColor = Color.FromArgb(176, 60, 60);
            button4.Location = new Point(5, 242);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 6;
            button4.Text = "Beverage";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button categoryBtn2;
        private Button categoryBtn1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}

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
            MainBackground = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            TabLeft = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            categoryBtn2 = new TouchTriggerButton();
            categoryBtn6 = new TouchTriggerButton();
            categoryBtn3 = new TouchTriggerButton();
            categoryBtn5 = new TouchTriggerButton();
            categoryBtn1 = new TouchTriggerButton();
            categoryBtn4 = new TouchTriggerButton();
            categoryLabel = new Label();
            TabRight = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            CategoryDisplayLabel = new Label();
            panel1 = new Panel();
            MenuGrid = new TableLayoutPanel();
            MainBackground.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            TabLeft.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // MainBackground
            // 
            MainBackground.BackColor = Color.FromArgb(245, 238, 224);
            MainBackground.Controls.Add(tableLayoutPanel1);
            MainBackground.Dock = DockStyle.Fill;
            MainBackground.Location = new Point(0, 0);
            MainBackground.Name = "MainBackground";
            MainBackground.Size = new Size(800, 450);
            MainBackground.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel3.Controls.Add(TabLeft, 0, 0);
            tableLayoutPanel3.Controls.Add(TabRight, 2, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 115);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(794, 332);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // TabLeft
            // 
            TabLeft.BackColor = Color.FromArgb(219, 196, 165);
            TabLeft.Controls.Add(tableLayoutPanel2);
            TabLeft.Controls.Add(categoryLabel);
            TabLeft.Dock = DockStyle.Fill;
            TabLeft.Location = new Point(3, 3);
            TabLeft.Name = "TabLeft";
            TabLeft.Size = new Size(242, 326);
            TabLeft.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(categoryBtn2, 0, 1);
            tableLayoutPanel2.Controls.Add(categoryBtn6, 0, 5);
            tableLayoutPanel2.Controls.Add(categoryBtn3, 0, 2);
            tableLayoutPanel2.Controls.Add(categoryBtn5, 0, 4);
            tableLayoutPanel2.Controls.Add(categoryBtn1, 0, 0);
            tableLayoutPanel2.Controls.Add(categoryBtn4, 0, 3);
            tableLayoutPanel2.Location = new Point(3, 52);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(236, 232);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // categoryBtn2
            // 
            categoryBtn2.Dock = DockStyle.Fill;
            categoryBtn2.FlatStyle = FlatStyle.Flat;
            categoryBtn2.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn2.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn2.Location = new Point(3, 41);
            categoryBtn2.Name = "categoryBtn2";
            categoryBtn2.Padding = new Padding(5, 0, 0, 0);
            categoryBtn2.Size = new Size(230, 32);
            categoryBtn2.TabIndex = 2;
            categoryBtn2.TabStop = false;
            categoryBtn2.Text = "Coffee";
            categoryBtn2.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn2.UseVisualStyleBackColor = true;
            // 
            // categoryBtn6
            // 
            categoryBtn6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryBtn6.Dock = DockStyle.Fill;
            categoryBtn6.FlatStyle = FlatStyle.Flat;
            categoryBtn6.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn6.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn6.Location = new Point(3, 193);
            categoryBtn6.Name = "categoryBtn6";
            categoryBtn6.Padding = new Padding(5, 0, 0, 0);
            categoryBtn6.Size = new Size(230, 36);
            categoryBtn6.TabIndex = 6;
            categoryBtn6.TabStop = false;
            categoryBtn6.Text = "Beverage";
            categoryBtn6.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn6.UseVisualStyleBackColor = true;
            // 
            // categoryBtn3
            // 
            categoryBtn3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryBtn3.FlatStyle = FlatStyle.Flat;
            categoryBtn3.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn3.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn3.Location = new Point(3, 79);
            categoryBtn3.Name = "categoryBtn3";
            categoryBtn3.Padding = new Padding(5, 0, 0, 0);
            categoryBtn3.Size = new Size(230, 32);
            categoryBtn3.TabIndex = 3;
            categoryBtn3.TabStop = false;
            categoryBtn3.Text = "Pantries";
            categoryBtn3.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn3.UseVisualStyleBackColor = true;
            // 
            // categoryBtn5
            // 
            categoryBtn5.Dock = DockStyle.Fill;
            categoryBtn5.FlatStyle = FlatStyle.Flat;
            categoryBtn5.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn5.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn5.Location = new Point(3, 155);
            categoryBtn5.Name = "categoryBtn5";
            categoryBtn5.Padding = new Padding(5, 0, 0, 0);
            categoryBtn5.Size = new Size(230, 32);
            categoryBtn5.TabIndex = 5;
            categoryBtn5.TabStop = false;
            categoryBtn5.Text = "Side Dish";
            categoryBtn5.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn5.UseVisualStyleBackColor = true;
            // 
            // categoryBtn1
            // 
            categoryBtn1.Dock = DockStyle.Fill;
            categoryBtn1.FlatStyle = FlatStyle.Flat;
            categoryBtn1.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn1.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn1.Location = new Point(3, 3);
            categoryBtn1.Name = "categoryBtn1";
            categoryBtn1.Padding = new Padding(5, 0, 0, 0);
            categoryBtn1.Size = new Size(230, 32);
            categoryBtn1.TabIndex = 1;
            categoryBtn1.TabStop = false;
            categoryBtn1.Text = "Top Picks";
            categoryBtn1.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn1.UseVisualStyleBackColor = true;
            // 
            // categoryBtn4
            // 
            categoryBtn4.Dock = DockStyle.Fill;
            categoryBtn4.FlatStyle = FlatStyle.Flat;
            categoryBtn4.Font = new Font("Bahnschrift SemiCondensed", 10F);
            categoryBtn4.ForeColor = Color.FromArgb(176, 60, 60);
            categoryBtn4.Location = new Point(3, 117);
            categoryBtn4.Name = "categoryBtn4";
            categoryBtn4.Padding = new Padding(5, 0, 0, 0);
            categoryBtn4.Size = new Size(230, 32);
            categoryBtn4.TabIndex = 4;
            categoryBtn4.TabStop = false;
            categoryBtn4.Text = "Main Dish";
            categoryBtn4.TextAlign = ContentAlignment.MiddleLeft;
            categoryBtn4.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = Color.FromArgb(100, 36, 29);
            categoryLabel.Location = new Point(5, 21);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 28);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Categories";
            // 
            // TabRight
            // 
            TabRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabRight.BackColor = Color.FromArgb(154, 171, 145);
            TabRight.Location = new Point(548, 3);
            TabRight.Name = "TabRight";
            TabRight.Size = new Size(243, 326);
            TabRight.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(MenuGrid, 0, 1);
            tableLayoutPanel4.Controls.Add(CategoryDisplayLabel, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(251, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.930233F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58.13954F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.930233F));
            tableLayoutPanel4.Size = new Size(291, 326);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // CategoryDisplayLabel
            // 
            CategoryDisplayLabel.AutoSize = true;
            CategoryDisplayLabel.Dock = DockStyle.Fill;
            CategoryDisplayLabel.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDisplayLabel.ForeColor = Color.FromArgb(100, 36, 29);
            CategoryDisplayLabel.Location = new Point(3, 0);
            CategoryDisplayLabel.Name = "CategoryDisplayLabel";
            CategoryDisplayLabel.Size = new Size(285, 68);
            CategoryDisplayLabel.TabIndex = 3;
            CategoryDisplayLabel.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 246, 238);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 106);
            panel1.TabIndex = 1;
            // 
            // MenuGrid
            // 
            MenuGrid.ColumnCount = 3;
            MenuGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuGrid.Dock = DockStyle.Fill;
            MenuGrid.Location = new Point(3, 71);
            MenuGrid.Name = "MenuGrid";
            MenuGrid.RowCount = 3;
            MenuGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MenuGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MenuGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MenuGrid.Size = new Size(285, 183);
            MenuGrid.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(MainBackground);
            Name = "Form1";
            Text = "Form1";
            MainBackground.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            TabLeft.ResumeLayout(false);
            TabLeft.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel MainBackground;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel TabLeft;
        private Panel TabRight;
        private TableLayoutPanel tableLayoutPanel2;
        private Label categoryLabel;
        private TouchTriggerButton categoryBtn1;
        private TouchTriggerButton categoryBtn2;
        private TouchTriggerButton categoryBtn3;
        private TouchTriggerButton categoryBtn4;
        private TouchTriggerButton categoryBtn5;
        private TouchTriggerButton categoryBtn6;
        private Label CategoryDisplayLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private TableLayoutPanel MenuGrid;
    }
}

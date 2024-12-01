namespace ToolStrip
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
            menuStrip1 = new MenuStrip();
            операціToolStripMenuItem = new ToolStripMenuItem();
            додаванняToolStripMenuItem = new ToolStripMenuItem();
            відніманняToolStripMenuItem = new ToolStripMenuItem();
            додатковоToolStripMenuItem = new ToolStripMenuItem();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            TextBoxNumber1 = new TextBox();
            TextBoxNumber2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { операціToolStripMenuItem, додатковоToolStripMenuItem, вихідToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(351, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // операціToolStripMenuItem
            // 
            операціToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додаванняToolStripMenuItem, відніманняToolStripMenuItem });
            операціToolStripMenuItem.Name = "операціToolStripMenuItem";
            операціToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            операціToolStripMenuItem.Size = new Size(85, 24);
            операціToolStripMenuItem.Text = "Операції";
            // 
            // додаванняToolStripMenuItem
            // 
            додаванняToolStripMenuItem.Name = "додаванняToolStripMenuItem";
            додаванняToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            додаванняToolStripMenuItem.Size = new Size(224, 26);
            додаванняToolStripMenuItem.Text = "Додавання";
            додаванняToolStripMenuItem.Click += додаванняToolStripMenuItem_Click;
            // 
            // відніманняToolStripMenuItem
            // 
            відніманняToolStripMenuItem.Name = "відніманняToolStripMenuItem";
            відніманняToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            відніманняToolStripMenuItem.Size = new Size(224, 26);
            відніманняToolStripMenuItem.Text = "Віднімання";
            відніманняToolStripMenuItem.Click += відніманняToolStripMenuItem_Click;
            // 
            // додатковоToolStripMenuItem
            // 
            додатковоToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститиToolStripMenuItem });
            додатковоToolStripMenuItem.Name = "додатковоToolStripMenuItem";
            додатковоToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            додатковоToolStripMenuItem.Size = new Size(97, 24);
            додатковоToolStripMenuItem.Text = "Додатково";
            // 
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            очиститиToolStripMenuItem.Size = new Size(258, 26);
            очиститиToolStripMenuItem.Text = "Очистити форму";
            очиститиToolStripMenuItem.Click += очиститиToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            вихідToolStripMenuItem.Size = new Size(60, 24);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // TextBoxNumber1
            // 
            TextBoxNumber1.Location = new Point(55, 101);
            TextBoxNumber1.Name = "TextBoxNumber1";
            TextBoxNumber1.Size = new Size(125, 27);
            TextBoxNumber1.TabIndex = 1;
            // 
            // TextBoxNumber2
            // 
            TextBoxNumber2.Location = new Point(55, 180);
            TextBoxNumber2.Name = "TextBoxNumber2";
            TextBoxNumber2.Size = new Size(125, 27);
            TextBoxNumber2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 74);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 3;
            label1.Text = "Введіть перше число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 156);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 4;
            label2.Text = "Введіть друге число";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 273);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxNumber2);
            Controls.Add(TextBoxNumber1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem операціToolStripMenuItem;
        private ToolStripMenuItem додаванняToolStripMenuItem;
        private ToolStripMenuItem відніманняToolStripMenuItem;
        private ToolStripMenuItem додатковоToolStripMenuItem;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private TextBox TextBoxNumber1;
        private TextBox TextBoxNumber2;
        private Label label1;
        private Label label2;
    }
}
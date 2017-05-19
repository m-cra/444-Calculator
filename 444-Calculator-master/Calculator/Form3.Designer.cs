namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomMaxValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complexResultBox = new System.Windows.Forms.RichTextBox();
            this.complexAddButton = new System.Windows.Forms.Button();
            this.complexSubButton = new System.Windows.Forms.Button();
            this.complexDivButton = new System.Windows.Forms.Button();
            this.complexMagButton = new System.Windows.Forms.Button();
            this.complexSolveButton = new System.Windows.Forms.Button();
            this.eq1button2 = new System.Windows.Forms.TextBox();
            this.eq1button1 = new System.Windows.Forms.TextBox();
            this.eq2button1 = new System.Windows.Forms.TextBox();
            this.eq2button2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCalcToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // basicCalcToolStripMenuItem
            // 
            this.basicCalcToolStripMenuItem.Name = "basicCalcToolStripMenuItem";
            this.basicCalcToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.basicCalcToolStripMenuItem.Text = "Basic Calc";
            this.basicCalcToolStripMenuItem.Click += new System.EventHandler(this.basicCalcToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.randomMaxValueToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // randomMaxValueToolStripMenuItem
            // 
            this.randomMaxValueToolStripMenuItem.Name = "randomMaxValueToolStripMenuItem";
            this.randomMaxValueToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.randomMaxValueToolStripMenuItem.Text = "Random / Max Value";
            // 
            // complexResultBox
            // 
            this.complexResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complexResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexResultBox.Location = new System.Drawing.Point(12, 66);
            this.complexResultBox.Name = "complexResultBox";
            this.complexResultBox.Size = new System.Drawing.Size(361, 96);
            this.complexResultBox.TabIndex = 23;
            this.complexResultBox.Text = "";
            // 
            // complexAddButton
            // 
            this.complexAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.complexAddButton.AutoSize = true;
            this.complexAddButton.BackColor = System.Drawing.Color.LightGray;
            this.complexAddButton.Location = new System.Drawing.Point(12, 432);
            this.complexAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.complexAddButton.Name = "complexAddButton";
            this.complexAddButton.Size = new System.Drawing.Size(90, 82);
            this.complexAddButton.TabIndex = 24;
            this.complexAddButton.Text = "Add";
            this.complexAddButton.UseVisualStyleBackColor = false;
            this.complexAddButton.Click += new System.EventHandler(this.complexAddButton_Click);
            this.complexAddButton.MouseEnter += new System.EventHandler(this.complexSolveButton_MouseEnter);
            this.complexAddButton.MouseLeave += new System.EventHandler(this.complexSolveButton_MouseLeave);
            // 
            // complexSubButton
            // 
            this.complexSubButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.complexSubButton.AutoSize = true;
            this.complexSubButton.BackColor = System.Drawing.Color.LightGray;
            this.complexSubButton.Location = new System.Drawing.Point(192, 432);
            this.complexSubButton.Margin = new System.Windows.Forms.Padding(0);
            this.complexSubButton.Name = "complexSubButton";
            this.complexSubButton.Size = new System.Drawing.Size(90, 82);
            this.complexSubButton.TabIndex = 26;
            this.complexSubButton.Text = "Ang";
            this.complexSubButton.UseVisualStyleBackColor = false;
            this.complexSubButton.Click += new System.EventHandler(this.complexSubButton_Click);
            this.complexSubButton.MouseEnter += new System.EventHandler(this.complexSolveButton_MouseEnter);
            this.complexSubButton.MouseLeave += new System.EventHandler(this.complexSolveButton_MouseLeave);
            // 
            // complexDivButton
            // 
            this.complexDivButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.complexDivButton.AutoSize = true;
            this.complexDivButton.BackColor = System.Drawing.Color.LightGray;
            this.complexDivButton.Location = new System.Drawing.Point(102, 432);
            this.complexDivButton.Margin = new System.Windows.Forms.Padding(0);
            this.complexDivButton.Name = "complexDivButton";
            this.complexDivButton.Size = new System.Drawing.Size(90, 82);
            this.complexDivButton.TabIndex = 25;
            this.complexDivButton.Text = "Div";
            this.complexDivButton.UseVisualStyleBackColor = false;
            this.complexDivButton.Click += new System.EventHandler(this.complexDivButton_Click);
            this.complexDivButton.MouseEnter += new System.EventHandler(this.complexSolveButton_MouseEnter);
            this.complexDivButton.MouseLeave += new System.EventHandler(this.complexSolveButton_MouseLeave);
            // 
            // complexMagButton
            // 
            this.complexMagButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.complexMagButton.AutoSize = true;
            this.complexMagButton.BackColor = System.Drawing.Color.LightGray;
            this.complexMagButton.Location = new System.Drawing.Point(282, 432);
            this.complexMagButton.Margin = new System.Windows.Forms.Padding(0);
            this.complexMagButton.Name = "complexMagButton";
            this.complexMagButton.Size = new System.Drawing.Size(90, 82);
            this.complexMagButton.TabIndex = 27;
            this.complexMagButton.Text = "Mag";
            this.complexMagButton.UseVisualStyleBackColor = false;
            this.complexMagButton.Click += new System.EventHandler(this.complexMagButton_Click);
            this.complexMagButton.MouseEnter += new System.EventHandler(this.complexSolveButton_MouseEnter);
            this.complexMagButton.MouseLeave += new System.EventHandler(this.complexSolveButton_MouseLeave);
            // 
            // complexSolveButton
            // 
            this.complexSolveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.complexSolveButton.AutoSize = true;
            this.complexSolveButton.BackColor = System.Drawing.Color.LightGray;
            this.complexSolveButton.Location = new System.Drawing.Point(12, 548);
            this.complexSolveButton.Margin = new System.Windows.Forms.Padding(0);
            this.complexSolveButton.Name = "complexSolveButton";
            this.complexSolveButton.Size = new System.Drawing.Size(360, 82);
            this.complexSolveButton.TabIndex = 28;
            this.complexSolveButton.Text = "Clear";
            this.complexSolveButton.UseVisualStyleBackColor = false;
            this.complexSolveButton.Click += new System.EventHandler(this.complexSolveButton_Click);
            this.complexSolveButton.MouseEnter += new System.EventHandler(this.complexSolveButton_MouseEnter);
            this.complexSolveButton.MouseLeave += new System.EventHandler(this.complexSolveButton_MouseLeave);
            // 
            // eq1button2
            // 
            this.eq1button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq1button2.Location = new System.Drawing.Point(246, 235);
            this.eq1button2.Name = "eq1button2";
            this.eq1button2.Size = new System.Drawing.Size(90, 38);
            this.eq1button2.TabIndex = 20;
            // 
            // eq1button1
            // 
            this.eq1button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq1button1.Location = new System.Drawing.Point(55, 235);
            this.eq1button1.Name = "eq1button1";
            this.eq1button1.Size = new System.Drawing.Size(91, 38);
            this.eq1button1.TabIndex = 19;
            // 
            // eq2button1
            // 
            this.eq2button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq2button1.Location = new System.Drawing.Point(55, 295);
            this.eq2button1.Name = "eq2button1";
            this.eq2button1.Size = new System.Drawing.Size(91, 38);
            this.eq2button1.TabIndex = 21;
            // 
            // eq2button2
            // 
            this.eq2button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq2button2.Location = new System.Drawing.Point(246, 295);
            this.eq2button2.Name = "eq2button2";
            this.eq2button2.Size = new System.Drawing.Size(90, 38);
            this.eq2button2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "i";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "i";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eq2button2);
            this.Controls.Add(this.eq2button1);
            this.Controls.Add(this.eq1button1);
            this.Controls.Add(this.eq1button2);
            this.Controls.Add(this.complexSolveButton);
            this.Controls.Add(this.complexMagButton);
            this.Controls.Add(this.complexDivButton);
            this.Controls.Add(this.complexSubButton);
            this.Controls.Add(this.complexAddButton);
            this.Controls.Add(this.complexResultBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Complex Number Calculator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCalcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomMaxValueToolStripMenuItem;
        private System.Windows.Forms.RichTextBox complexResultBox;
        private System.Windows.Forms.Button complexAddButton;
        private System.Windows.Forms.Button complexSubButton;
        private System.Windows.Forms.Button complexDivButton;
        private System.Windows.Forms.Button complexMagButton;
        private System.Windows.Forms.Button complexSolveButton;
        private System.Windows.Forms.TextBox eq1button2;
        private System.Windows.Forms.TextBox eq1button1;
        private System.Windows.Forms.TextBox eq2button1;
        private System.Windows.Forms.TextBox eq2button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
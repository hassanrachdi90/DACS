namespace DACS
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
            l1 = new Label();
            l2 = new Label();
            b1 = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            SuspendLayout();
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(218, 85);
            l1.Name = "l1";
            l1.Size = new Size(53, 20);
            l1.TabIndex = 0;
            l1.Text = "Login :";
            l1.Click += label1_Click;
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Location = new Point(218, 138);
            l2.Name = "l2";
            l2.Size = new Size(77, 20);
            l2.TabIndex = 1;
            l2.Text = "Password :";
            // 
            // b1
            // 
            b1.Location = new Point(333, 202);
            b1.Name = "b1";
            b1.Size = new Size(94, 29);
            b1.TabIndex = 2;
            b1.Text = "Connecte";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(322, 85);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 3;
            // 
            // tb2
            // 
            tb2.Location = new Point(322, 138);
            tb2.Name = "tb2";
            tb2.Size = new Size(125, 27);
            tb2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(b1);
            Controls.Add(l2);
            Controls.Add(l1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l1;
        private Label l2;
        private Button b1;
        private TextBox tb1;
        private TextBox tb2;
    }
}
namespace PR1_Chub_TRS_3_SVIY
{
    partial class Chub_PR1_TRS
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 499);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(310, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(278, 499);
            listBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(607, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 500);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 518);
            button1.Name = "button1";
            button1.Size = new Size(858, 40);
            button1.TabIndex = 3;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Chub_PR1_TRS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 561);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Chub_PR1_TRS";
            Text = "Chub_PR1_TRS";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Panel panel1;
        private Button button1;
    }
}

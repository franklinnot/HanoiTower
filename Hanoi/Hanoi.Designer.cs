namespace Hanoi
{
    partial class Hanoi
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
            listBox3 = new ListBox();
            btnMove1 = new Button();
            btnMove2 = new Button();
            btnMove3 = new Button();
            label1 = new Label();
            btnRestart = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(70, 199);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(123, 84);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(70, 199);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(214, 84);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(70, 199);
            listBox3.TabIndex = 3;
            // 
            // btnMove1
            // 
            btnMove1.BackColor = Color.LightGreen;
            btnMove1.ForeColor = SystemColors.ControlText;
            btnMove1.Location = new Point(44, 289);
            btnMove1.Name = "btnMove1";
            btnMove1.Size = new Size(45, 23);
            btnMove1.TabIndex = 4;
            btnMove1.Text = "move";
            btnMove1.UseVisualStyleBackColor = false;
            btnMove1.Click += btnMove1_Click;
            // 
            // btnMove2
            // 
            btnMove2.BackColor = Color.LightGreen;
            btnMove2.Location = new Point(135, 289);
            btnMove2.Name = "btnMove2";
            btnMove2.Size = new Size(45, 23);
            btnMove2.TabIndex = 5;
            btnMove2.Text = "move";
            btnMove2.UseVisualStyleBackColor = false;
            btnMove2.Click += btnMove2_Click;
            // 
            // btnMove3
            // 
            btnMove3.BackColor = Color.LightGreen;
            btnMove3.Location = new Point(226, 289);
            btnMove3.Name = "btnMove3";
            btnMove3.Size = new Size(45, 23);
            btnMove3.TabIndex = 6;
            btnMove3.Text = "move";
            btnMove3.UseVisualStyleBackColor = false;
            btnMove3.Click += btnMove3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(57, 28);
            label1.Name = "label1";
            label1.Size = new Size(196, 16);
            label1.TabIndex = 7;
            label1.Text = "Ordena las torres de Hanoi";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(70, 70, 70);
            btnRestart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestart.ForeColor = SystemColors.HighlightText;
            btnRestart.Location = new Point(126, 335);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(60, 23);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.HotPink;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 9;
            label2.Text = "TORRE UNO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DeepSkyBlue;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(122, 64);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 10;
            label3.Text = "TORRE DOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(214, 64);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 11;
            label4.Text = "TORRE TRES";
            // 
            // Hanoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(317, 383);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRestart);
            Controls.Add(label1);
            Controls.Add(btnMove3);
            Controls.Add(btnMove2);
            Controls.Add(btnMove1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Hanoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torres de Hanoi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button btnMove1;
        private Button btnMove2;
        private Button btnMove3;
        private Label label1;
        private Button btnRestart;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
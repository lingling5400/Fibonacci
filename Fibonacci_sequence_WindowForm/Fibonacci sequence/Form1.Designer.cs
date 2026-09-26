namespace Fibonacci_sequence
{
    partial class frmFibonacci
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
            txtShow = new TextBox();
            lblResult = new Label();
            lblWord2 = new Label();
            lblWord = new Label();
            txtUser = new TextBox();
            btnRun = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtShow);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(lblWord2);
            panel1.Controls.Add(lblWord);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(btnRun);
            panel1.Location = new Point(33, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 538);
            panel1.TabIndex = 0;
            // 
            // txtShow
            // 
            txtShow.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtShow.Location = new Point(99, 338);
            txtShow.Multiline = true;
            txtShow.Name = "txtShow";
            txtShow.Size = new Size(634, 163);
            txtShow.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft JhengHei UI", 12F);
            lblResult.Location = new Point(99, 274);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(133, 36);
            lblResult.TabIndex = 4;
            lblResult.Text = "執行結果:";
            // 
            // lblWord2
            // 
            lblWord2.AutoSize = true;
            lblWord2.Font = new Font("Microsoft JhengHei UI", 12F);
            lblWord2.Location = new Point(99, 166);
            lblWord2.Name = "lblWord2";
            lblWord2.Size = new Size(133, 36);
            lblWord2.TabIndex = 3;
            lblWord2.Text = "輸入數字:";
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Microsoft JhengHei UI", 12F);
            lblWord.Location = new Point(99, 71);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(398, 36);
            lblWord.TabIndex = 2;
            lblWord.Text = "費式數列規則: 1,1,2,3,5,8,13, ... ";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Microsoft JhengHei UI", 12F);
            txtUser.Location = new Point(256, 159);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 43);
            txtUser.TabIndex = 1;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft JhengHei UI", 12F);
            btnRun.Location = new Point(602, 164);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(131, 40);
            btnRun.TabIndex = 0;
            btnRun.Text = "執行";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // frmFibonacci
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 687);
            Controls.Add(panel1);
            Name = "frmFibonacci";
            Text = "費式數列計算機";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblResult;
        private Label lblWord2;
        private Label lblWord;
        private TextBox txtUser;
        private Button btnRun;
        private TextBox txtShow;
    }
}

namespace CatchButton
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
            chase_but = new Button();
            restart = new Button();
            SuspendLayout();
            // 
            // chase_but
            // 
            chase_but.BackColor = Color.LawnGreen;
            chase_but.Font = new Font("맑은 고딕", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chase_but.ForeColor = Color.Navy;
            chase_but.Location = new Point(878, 402);
            chase_but.Name = "chase_but";
            chase_but.Size = new Size(250, 75);
            chase_but.TabIndex = 0;
            chase_but.Text = "나를 잡아봐";
            chase_but.UseVisualStyleBackColor = false;
            chase_but.Click += chase_but_Click;
            chase_but.MouseEnter += chase_but_MouseEnter;
            // 
            // restart
            // 
            restart.Enabled = false;
            restart.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            restart.Location = new Point(517, 248);
            restart.Name = "restart";
            restart.Size = new Size(202, 68);
            restart.TabIndex = 1;
            restart.Text = "다시 시작!";
            restart.UseVisualStyleBackColor = true;
            restart.Visible = false;
            restart.Click += restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1256, 611);
            Controls.Add(restart);
            Controls.Add(chase_but);
            Name = "Form1";
            Text = "버튼 잡기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button chase_but;
        private Button restart;
    }
}

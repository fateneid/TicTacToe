namespace TicTacToe
{
    partial class frmStart
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
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbP1Symbol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numRounds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(305, 360);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 69);
            this.btnStart.TabIndex = 33;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbP1Symbol
            // 
            this.cmbP1Symbol.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbP1Symbol.FormattingEnabled = true;
            this.cmbP1Symbol.Items.AddRange(new object[] {
            "X",
            "O"});
            this.cmbP1Symbol.Location = new System.Drawing.Point(343, 242);
            this.cmbP1Symbol.Name = "cmbP1Symbol";
            this.cmbP1Symbol.Size = new System.Drawing.Size(91, 31);
            this.cmbP1Symbol.TabIndex = 32;
            this.cmbP1Symbol.Text = "X or O";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(224, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "Player 1:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.Location = new System.Drawing.Point(437, 195);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(140, 30);
            this.txtPlayer2Name.TabIndex = 30;
            this.txtPlayer2Name.Text = "Player 2";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(437, 140);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(140, 30);
            this.txtPlayer1Name.TabIndex = 29;
            this.txtPlayer1Name.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(224, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "Player 2\'s Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(224, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Player 1\'s Name: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(232, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 69);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Tic-Tac-Toe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(224, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rounds:";
            // 
            // numRounds
            // 
            this.numRounds.Location = new System.Drawing.Point(343, 297);
            this.numRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRounds.Name = "numRounds";
            this.numRounds.Size = new System.Drawing.Size(91, 26);
            this.numRounds.TabIndex = 36;
            this.numRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.numRounds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbP1Symbol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmStart";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.frmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbP1Symbol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRounds;
    }
}
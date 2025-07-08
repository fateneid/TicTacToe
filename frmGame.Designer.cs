namespace TicTacToe
{
    partial class frmGame
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinnerTitle = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalRounds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblDrawWins = new System.Windows.Forms.Label();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
            this.lblPlayer1Wins = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(588, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic-Tac-Toe";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(118, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "Turn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(118, 510);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(251, 47);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinnerTitle
            // 
            this.lblWinnerTitle.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWinnerTitle.Location = new System.Drawing.Point(72, 442);
            this.lblWinnerTitle.Name = "lblWinnerTitle";
            this.lblWinnerTitle.Size = new System.Drawing.Size(342, 47);
            this.lblWinnerTitle.TabIndex = 6;
            this.lblWinnerTitle.Text = "Winner";
            this.lblWinnerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(118, 374);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(251, 47);
            this.lblTurn.TabIndex = 7;
            this.lblTurn.Text = "Player 1";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(145, 588);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(190, 69);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(0, 0);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(75, 23);
            this.btnStart1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(508, 522);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(135, 135);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 47;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "\"?\"";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(874, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "\"?\"";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(874, 522);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(135, 135);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 53;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "\"?\"";
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(691, 339);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(135, 135);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "\"?\"";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(691, 522);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(135, 135);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "\"?\"";
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(508, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "\"?\"";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(691, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "\"?\"";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(508, 339);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(135, 135);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "\"?\"";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(874, 339);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(135, 135);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "\"?\"";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalRounds);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCurrentRound);
            this.groupBox1.Controls.Add(this.lblDrawWins);
            this.groupBox1.Controls.Add(this.lblPlayer2Wins);
            this.groupBox1.Controls.Add(this.lblPlayer1Wins);
            this.groupBox1.Controls.Add(this.lblDraw);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPlayer2Name);
            this.groupBox1.Controls.Add(this.lblPlayer1Name);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(108, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 287);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblTotalRounds
            // 
            this.lblTotalRounds.AutoSize = true;
            this.lblTotalRounds.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblTotalRounds.ForeColor = System.Drawing.Color.White;
            this.lblTotalRounds.Location = new System.Drawing.Point(228, 224);
            this.lblTotalRounds.Name = "lblTotalRounds";
            this.lblTotalRounds.Size = new System.Drawing.Size(30, 33);
            this.lblTotalRounds.TabIndex = 66;
            this.lblTotalRounds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(31, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 33);
            this.label2.TabIndex = 65;
            this.label2.Text = "Total Rounds: ";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCurrentRound.ForeColor = System.Drawing.Color.White;
            this.lblCurrentRound.Location = new System.Drawing.Point(228, 183);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(30, 33);
            this.lblCurrentRound.TabIndex = 64;
            this.lblCurrentRound.Text = "0";
            // 
            // lblDrawWins
            // 
            this.lblDrawWins.AutoSize = true;
            this.lblDrawWins.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblDrawWins.ForeColor = System.Drawing.Color.White;
            this.lblDrawWins.Location = new System.Drawing.Point(160, 142);
            this.lblDrawWins.Name = "lblDrawWins";
            this.lblDrawWins.Size = new System.Drawing.Size(30, 33);
            this.lblDrawWins.TabIndex = 63;
            this.lblDrawWins.Text = "0";
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.AutoSize = true;
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblPlayer2Wins.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Wins.Location = new System.Drawing.Point(160, 101);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(30, 33);
            this.lblPlayer2Wins.TabIndex = 61;
            this.lblPlayer2Wins.Text = "0";
            // 
            // lblPlayer1Wins
            // 
            this.lblPlayer1Wins.AutoSize = true;
            this.lblPlayer1Wins.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblPlayer1Wins.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Wins.Location = new System.Drawing.Point(160, 60);
            this.lblPlayer1Wins.Name = "lblPlayer1Wins";
            this.lblPlayer1Wins.Size = new System.Drawing.Size(30, 33);
            this.lblPlayer1Wins.TabIndex = 60;
            this.lblPlayer1Wins.Text = "0";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDraw.Location = new System.Drawing.Point(33, 142);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(86, 33);
            this.lblDraw.TabIndex = 62;
            this.lblDraw.Text = "Draw: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(33, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 33);
            this.label6.TabIndex = 59;
            this.label6.Text = "Current Round: ";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlayer2Name.Location = new System.Drawing.Point(33, 101);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(120, 33);
            this.lblPlayer2Name.TabIndex = 58;
            this.lblPlayer2Name.Text = "Player 2: ";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlayer1Name.Location = new System.Drawing.Point(33, 60);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(116, 33);
            this.lblPlayer1Name.TabIndex = 57;
            this.lblPlayer1Name.Text = "Player 1: ";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblWinnerTitle);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmGame";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblWinnerTitle;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlayer2Wins;
        private System.Windows.Forms.Label lblPlayer1Wins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblDrawWins;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblTotalRounds;
        private System.Windows.Forms.Label label2;
    }
}


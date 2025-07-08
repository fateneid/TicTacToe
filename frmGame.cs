using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class frmGame : Form
    {
        public frmGame(string p1Name, string p2Name, bool p1IsX, int numRounds)
        {
            InitializeComponent();

            this.FormClosed += (s, e) =>
            {
                if (!this.IsDisposed && Application.OpenForms.Count == 0)
                    Application.Exit();
            };

            GameInfo.Player1Name = p1Name;
            GameInfo.Player2Name = p2Name;
            GameInfo.IsPlayer1X = p1IsX;
            GameInfo.TotalRounds = numRounds;

        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }
        enum enPlayerTurn
        {
            Player1,
            Player2
        }
        struct stGameInfo
        {
            public string Player1Name;
            public string Player2Name;
            public bool IsPlayer1X;
            public int TotalRounds;
        }
        struct stRoundStatus
        {
            public enPlayerTurn PlayerTurn;
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        struct stWinStats
        {
            public int Player1Wins;
            public int Player2Wins;
            public int Draw;
            public int CurrentRound;
        }
    
        stGameInfo GameInfo;
        stRoundStatus RoundStatus;
        stWinStats WinStats;

        private void frmGame_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.White, 5);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            float dis = (32 - pen.Width) / 2;

            // Horizontal lines
            float x1 = pictureBox1.Left - dis, y1 = pictureBox1.Bottom + dis;
            float x2 = pictureBox3.Right + dis, y2 = pictureBox4.Bottom + dis;

            e.Graphics.DrawLine(pen, x1, y1, x2, y1);
            e.Graphics.DrawLine(pen, x1, y2, x2, y2);

            // Vertical lines
            float x3 = pictureBox1.Right + dis, y3 = pictureBox2.Top - dis;
            float x4 = pictureBox2.Right + dis, y4 = pictureBox7.Bottom + dis;

            e.Graphics.DrawLine(pen, x3, y3, x3, y4);
            e.Graphics.DrawLine(pen, x4, y3, x4, y4);

        }

        void ChangeImage(PictureBox pb)
        {

            if (RoundStatus.PlayerTurn == enPlayerTurn.Player1)
            {
                pb.Image = GameInfo.IsPlayer1X? Resources.X : Resources.O;
                pb.Tag = "X";
            }
            else
            {
                pb.Image = GameInfo.IsPlayer1X? Resources.O : Resources.X;
                pb.Tag = "O";
            }

            RoundStatus.PlayCount++;
            pb.Enabled = false;

        }
        void ChangeTurn()
        {

            if(RoundStatus.PlayerTurn == enPlayerTurn.Player1)
            {
                RoundStatus.PlayerTurn = enPlayerTurn.Player2;
                lblTurn.Text = GameInfo.Player2Name;
            }
            else
            {
                RoundStatus.PlayerTurn = enPlayerTurn.Player1;
                lblTurn.Text = GameInfo.Player1Name;
            }

        }
        bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if(pb1.Tag.ToString() != "?" && pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;

                if(pb1.Tag.ToString() == "X")
                {
                    RoundStatus.Winner = GameInfo.IsPlayer1X? enWinner.Player1 : enWinner.Player2;
                }
                else
                {
                    RoundStatus.Winner = GameInfo.IsPlayer1X? enWinner.Player2 : enWinner.Player1;
                }

                EndRound();
                return true;
            }
       
            return false;

        }
        void CheckWin()
        {

            if (RoundStatus.PlayCount < 5) return;

            //rows
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3)) return;
            if (CheckValues(pictureBox4, pictureBox5, pictureBox6)) return;
            if (CheckValues(pictureBox7, pictureBox8, pictureBox9)) return;
            //columns
            if (CheckValues(pictureBox1, pictureBox4, pictureBox7)) return;
            if (CheckValues(pictureBox2, pictureBox5, pictureBox8)) return;
            if (CheckValues(pictureBox3, pictureBox6, pictureBox9)) return;
            //diagonals
            if (CheckValues(pictureBox1, pictureBox5, pictureBox9)) return;
            if (CheckValues(pictureBox3, pictureBox5, pictureBox7)) return;

            if (RoundStatus.PlayCount == 9)
            {
                RoundStatus.Winner = enWinner.Draw;
                EndRound();
            }

        }
        void EndRound()
        {

            RoundStatus.GameOver = true;

            string TheWinner;
            if (RoundStatus.Winner == enWinner.Player1)
            {
                TheWinner = GameInfo.Player1Name;
                WinStats.Player1Wins++;
            }
            else if (RoundStatus.Winner == enWinner.Player2)
            {
                TheWinner = GameInfo.Player2Name;
                WinStats.Player2Wins++;
            }
            else
            {
                TheWinner = "Draw";
                WinStats.Draw++;
            }
            WinStats.CurrentRound++;
            UpdateStats();

            lblTurn.Text = "Game Over";
            lblWinner.Text = TheWinner;

            string WinMessage = (TheWinner == "Draw" ? "It's Draw" : TheWinner + " Wins ^_^");
            
            MessageBox.Show(WinMessage, "Round " + WinStats.CurrentRound +" End!", MessageBoxButtons.OK);

            if (WinStats.CurrentRound == GameInfo.TotalRounds) EndGame();
            else ResetRound();

        }
        void EndGame()
        {
            string TheFinalWinner;
            if (WinStats.Player1Wins > WinStats.Player2Wins) TheFinalWinner = GameInfo.Player1Name;
            else if (WinStats.Player2Wins > WinStats.Player1Wins) TheFinalWinner = GameInfo.Player2Name;
            else TheFinalWinner = "Draw";

            string WinMessage = (TheFinalWinner == "Draw" ? "It's Draw" : TheFinalWinner + " Wins ^_^");

            MessageBox.Show(WinMessage, "Game Over!", MessageBoxButtons.OK);

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;

            lblWinnerTitle.Text = "Final Winner";
            lblWinner.Text = TheFinalWinner;

        }
        void PlayAMove(PictureBox pb)
        {

            if (pb.Tag.ToString() == "?")
            {
                ChangeImage(pb);
                CheckWin();
 
                if (!RoundStatus.GameOver) ChangeTurn();

            }

        }
        void UpdateStats()
        {
            if (RoundStatus.GameOver)
            {
                lblPlayer1Wins.Text = WinStats.Player1Wins.ToString();
                lblPlayer2Wins.Text = WinStats.Player2Wins.ToString();
                lblDrawWins.Text = WinStats.Draw.ToString();
            }

        }
        void ResetPictureBox(PictureBox pb)
        {

            pb.Image = null;
            pb.Enabled = true;
            pb.Tag = "?";
            pb.BackColor = Color.Transparent;

        }
        void ResetRound()
        {

            ResetPictureBox(pictureBox1);
            ResetPictureBox(pictureBox2);
            ResetPictureBox(pictureBox3);
            ResetPictureBox(pictureBox4);
            ResetPictureBox(pictureBox5);
            ResetPictureBox(pictureBox6);
            ResetPictureBox(pictureBox7);
            ResetPictureBox(pictureBox8);
            ResetPictureBox(pictureBox9);

            RoundStatus.PlayCount = 0;
            RoundStatus.GameOver = false;
            RoundStatus.Winner = enWinner.GameInProgress;

            lblTurn.Text = (RoundStatus.PlayerTurn == enPlayerTurn.Player1)
                        ? GameInfo.Player1Name : GameInfo.Player2Name;

            lblWinner.Text = "In Progress";
            lblCurrentRound.Text = (WinStats.CurrentRound + 1).ToString();
            lblTotalRounds.Text = GameInfo.TotalRounds.ToString();

        }
        void LoadGame()
        {

            WinStats.Player1Wins = 0;
            WinStats.Player2Wins = 0;
            WinStats.Draw = 0;
            WinStats.CurrentRound = 0;

            lblPlayer1Name.Text = GameInfo.Player1Name;
            lblPlayer2Name.Text = GameInfo.Player2Name;

            ResetRound();

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PlayAMove((PictureBox)sender);
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            LoadGame();       
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            frmStart startForm = new frmStart();
            startForm.Show();
            this.Close();

        }


    }
}

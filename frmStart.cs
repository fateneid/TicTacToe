using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmGame gameForm = new frmGame(
                txtPlayer1Name.Text,
                txtPlayer2Name.Text,
                cmbP1Symbol.SelectedIndex == 0,
                (int)numRounds.Value
                );

            gameForm.ShowDialog();

            this.Show();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            txtPlayer1Name.Text = "Player 1";
            txtPlayer2Name.Text = "Player 2";
            cmbP1Symbol.SelectedIndex = 0;
            numRounds.Value = 1;
        }

    }
}

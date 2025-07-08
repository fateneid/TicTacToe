using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();

            this.FormClosed += (s, e) =>
            {
                if (!this.IsDisposed && Application.OpenForms.Count == 0)
                    Application.Exit();
            };

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            frmGame gameForm = new frmGame(
                txtPlayer1Name.Text,
                txtPlayer2Name.Text,
                cmbP1Symbol.SelectedIndex == 0,
                (int)numRounds.Value
                );

            gameForm.Show();
            this.Close();

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

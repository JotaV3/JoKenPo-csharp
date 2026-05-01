using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            
            GameManager.OnPlayerPlay += GameManager_OnPlayerPlay;
        }

        public void GameManager_OnPlayerPlay(object sender, EventArgs e)
        {
            picBoxPlayer.Image = GameManager.PlayerChoiceImg;
            picBoxPc.Image = GameManager.PcChoiceImg;
            picBoxResult.Image = GameManager.ResultImg;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            GameManager.Play(GameManager.Options.Rock);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            GameManager.Play(GameManager.Options.Paper);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            GameManager.Play(GameManager.Options.Scissors);
        }
    }
}

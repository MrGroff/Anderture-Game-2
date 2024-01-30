using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anderture_Game_2
{
    public partial class Form1 : Form
    {
        public string PlayerDecision { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerDecision = textBox1.Text;
            GameLogic gameLogic = new GameLogic();
            LookCommand lookcommand = new LookCommand();    
            gameLogic.PlayerDecision = PlayerDecision;
            gameLogic.PlayerLogic(PlayerDecision);
            if (gameLogic.QuestDialog != null)
            {
                label1.Text = gameLogic.QuestDialog;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

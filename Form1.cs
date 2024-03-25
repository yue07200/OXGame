using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OXGame
{
    public partial class Form1 : Form
    {
        string playerMarker = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = playerMarker;
            checkWinner();
            playerMarker = playerMarker == "X" ? "O" : "X"; //如果是 "X"，則返回 "O"，否則返回 "X"。
            label2.Text = playerMarker;


        }
        private void checkWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == playerMarker)
            {
                MessageBox.Show(button1.Text, "Winner is...");
                //return ; // 玩家獲勝後立即返回，不再繼續檢查其他可能的獲勝組合hj/

            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == playerMarker)
            {
                MessageBox.Show(button4.Text, "Winner is...");

            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == playerMarker)
            {
                MessageBox.Show(button7.Text, "Winner is...");

            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == playerMarker)
            {
                MessageBox.Show(button1.Text, "Winner is...");

            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == playerMarker)
            {
                MessageBox.Show(button2.Text, "Winner is...");

            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text == playerMarker)
            {
                MessageBox.Show(button3.Text, "Winner is...");

            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == playerMarker)
            {
                MessageBox.Show(button1.Text, "Winner is...");

            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == playerMarker)
            {
                MessageBox.Show(button3.Text, "Winner is...");

            }
            //DialogResult result = MessageBox.Show(MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //}
            //else if (result == DialogResult.No)
            //{
            //}
        }


    }
}
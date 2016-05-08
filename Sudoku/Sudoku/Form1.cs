using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class GameField : Form
    {
        // Global variables
        static int[,] GameArray = new int[9, 9];

        public GameField()
        {
            InitializeComponent();
            SudokuBoard.generateSolution(GameArray);
            foreach (int Field in GameArray)
            {
                 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public static void sdc_Validating(object sender, CancelEventArgs e)
        {
            SingleDigitCenteredTextBox sdc = (SingleDigitCenteredTextBox)sender;
            if (sdc.Text != "")
                setGameMessageBox(SudokuValidation.checkInput(GameArray, sender));
        }

        public static void setGameMessageBox(String Text)
        {
            GameMessageBox.Text = Text;
        }
    }
}

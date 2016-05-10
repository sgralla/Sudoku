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
            //SudokuBoard.generateSolutionRow(GameArray);
            //SudokuBoard.generateSolutionSquare(GameArray);
            //GameArray[0, 0] = 1;

            SudokuBoard.generateSmartSolutionRow(GameArray);

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
            //if (sdc.Text != "Gültige Zahl eingeben.")
                setGameMessageBox(SudokuValidation.checkInput(GameArray, sender));
            //else
            //    SudokuValidation.clearField(GameArray, sender);
          
        }

        public static void setGameMessageBox(String Text)
        {
            GameMessageBox.Text = Text;
        }
    }
}

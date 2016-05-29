using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class GameField : Form
    {
        // Global variables
        static int[,] GameArray = new int[9, 9];
        static int[,,] GameArrayValid = new int[9, 9, 9];


        public GameField()
        {
            InitializeComponent();
            SudokuValidation.initValid(GameArray, GameArrayValid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public static void sdc_Validating(object sender, CancelEventArgs e)
        {
            SingleDigitCenteredTextBox sdc = (SingleDigitCenteredTextBox)sender;
           // SudokuValidation.checkInput(GameArray, sender);
            SudokuValidation.updateValid(GameArray, GameArrayValid, sender);
        }

        public void setGameMessageBox(String Text)
        {
            GameMessageBox.Text = Text;
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int errorcounter = 0;

            //do
            //{
                SudokuBoard.generateSmartSolutionRow(GameArray);
                errorcounter = SudokuValidation.getNumberOfEmptyFields(GameArray);
            //    if (errorcounter != 0)
            //        SudokuBoard.clearGameFieldArray(GameArray);
            //} while (errorcounter != 0);

            SudokuBoard.updatePlayingField(PlayingField, GameArray);


            setGameMessageBox("Spielfeld mit " + errorcounter + " Fehlern gefüllt.");
                 
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuBoard.clearGameFieldArray(GameArray);
            SudokuBoard.updatePlayingField(PlayingField, GameArray);
            //GameMessageBox.Text = "Spielfeld geleert.";
            setGameMessageBox("Spielfeld geleert.");
        }

        private void Exit_Programm(object sender, EventArgs e)
        {
           if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                // The user wants to exit the application. Close everything down.
                Application.Exit();
        }

        private void IOcSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InpOut.writeGameFieldToCSV(GameArray);
        }
    }
}

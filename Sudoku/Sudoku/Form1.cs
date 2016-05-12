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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public static void sdc_Validating(object sender, CancelEventArgs e)
        {
            SingleDigitCenteredTextBox sdc = (SingleDigitCenteredTextBox)sender;
            SudokuValidation.checkInput(GameArray, sender);
        }

        public void setGameMessageBox(String Text)
        {
            GameMessageBox.Text = Text;
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuBoard.generateSmartSolutionRow(GameArray);

            SudokuBoard.updatePlayingField(PlayingField, GameArray);

            int errorcounter = 0;

            errorcounter = SudokuValidation.getNumberOfEmptyFields(GameArray);

            setGameMessageBox("Spielfeld mit " + errorcounter + " Fehlern gefüllt.");
                 
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuBoard.clearGameFieldArray(GameArray);
            SudokuBoard.updatePlayingField(PlayingField, GameArray);
            //GameMessageBox.Text = "Spielfeld geleert.";
            setGameMessageBox("Spielfeld geleert.");
        }
    }
}

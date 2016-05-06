using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class GameField : Form
    {
        // Global variables
        int[,] GameArray = new int[9, 9];

        public GameField()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void sdc_Validating(object sender, CancelEventArgs e)
        {
            SingleDigitCenteredTextBox sdc = (SingleDigitCenteredTextBox)sender;
            if (sdc.Text != "")
                GameMessageBox.Text = SudokuValidation.checkInput(GameArray, sender);
        }
    }
}

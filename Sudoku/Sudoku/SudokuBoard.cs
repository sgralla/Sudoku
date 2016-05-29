using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class SudokuBoard
    {
        internal static void clearGameFieldArray(int[,] gameArray)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gameArray[i, j] = 0;
                }
            }
        }

        internal static void updatePlayingField(GroupBox PlayingField, int[,] GameArray)
        {
            byte[] Position = new byte[2];
            int GameArrayText;
            foreach (SingleDigitCenteredTextBox sdc in PlayingField.Controls)
            {
                Position = SudokuValidation.getPosition(GameArray, sdc);
                GameArrayText = GameArray[Position[0], Position[1]];
                sdc.Text = GameArrayText != 0 ? GameArrayText.ToString() : "";
                sdc.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        internal static void fillGameField(int[,] GameField, int[,,] GameFieldValid)
        {
            //Random rnd = new Random();
            int insertable = 1;
            bool validEntryFound = false;
            int noValues = 0;
            //bool filled = false;

            while (insertable < 10 && !validEntryFound)
                for (int a = 0; a < 9; a++)
                {
                    for (int b = 0; b < 9; b++)
                    {
                        if (GameField[a, b] == 0 && GameFieldValid[a, b, 9] == 0)
                            noValues++;
                        else if (GameField[a, b] == 0 && GameFieldValid[a, b, 9] == insertable)
                        {
                            int insertval = 0;

                            for (int c = 0; c < 9; c++)
                            {
                                if (GameFieldValid[a, b, c] != 0)
                                {
                                    insertval = GameFieldValid[a, b, c];
                                    insertable = 2;
                                    validEntryFound = true;
                                    break;
                                }
                            }
                            SudokuValidation.setGameFieldValid(GameFieldValid, GameField, a, b, insertval, false);
                            if (validEntryFound) break;
                        }
                        else if (a == 8 && b == 8)
                            insertable++;
                    }
                    if (validEntryFound) break;
                    }
            

                }
            
        public static void showValidEntries(int[,,] GameFieldValid, int[,] GameArray, object sender, GroupBox ValidEntries)
        {
            byte[] Position = new byte[2];
            SingleDigitCenteredTextBox currentSDC = (SingleDigitCenteredTextBox)sender;
            Position = SudokuValidation.getPosition(GameArray, currentSDC);
            int x;

            foreach (SingleDigitCenteredTextBox V in ValidEntries.Controls)
            {
                x = Byte.Parse(V.Name.Substring(3, 1));
                V.Text = GameFieldValid[Position[0], Position[1], x].ToString();
            }

        }
    }
}

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
                // if ()
                Position = SudokuValidation.getPosition(GameArray, sdc);
                GameArrayText = GameArray[Position[0], Position[1]];
                //sdc.Text = Int32.ToString(GameArrayText, sdc.Text);
                sdc.Text = GameArrayText.ToString();
                sdc.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public static void generateSmartSolutionRow(int[,] GameField)
        {
            // To Output array to console
            int solveNumber; // debug variable

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //if (GameField[i, j] == 0)
                    //  GameField[i,j] = getNumberForRow(GameField, i, j);
                    //if (i == 3 && j ==5)
                    //    Console.WriteLine();

                    // To Output array to console
                    if (GameField[i, j] == 0)
                    {
                        solveNumber = getNumberForRow(GameField, i, j);
                        GameField[i, j] = solveNumber;
                        Console.Write(solveNumber + " ");
                    }
                    else
                        Console.Write(GameField[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    
        private static int getNumberForRow(int[,] GameField, int x, int y)
        {
            int RNumber = 0;
            int RPos = 0;
            int CPos = 0;
            //int CRNumber = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (SudokuValidation.validateInput(x, y, GameField, i, true, true, true))
                {
                    CPos = 0;
                    //RPos = 0;
                    for (int j = y; j < 9; j++)
                    {
                        if (SudokuValidation.validateInput(x, j, GameField, i, true, true, true))
                        {
                            CPos++;
                            //CRNumber = i;
                        }

                    }
                    if (CPos != 0 && ((RPos == 0) || (CPos <= RPos)))
                    {
                        RPos = CPos;
                        RNumber = i;
                        //if (RNumber == 1)
                        //    return RNumber;
                    }
                }
            }
            // Check if Input is valid for current Position else decrease Number;
            // Should be checked first
            //while (!SudokuValidation.validateInput(x, y, GameField, RNumber, true, true, true))
            //    --RNumber;

            return RNumber;
        }
    }
}

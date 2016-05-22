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

        internal static void fillGameField(int[,] GameField, int[,,] GameFieldValid)
        {
            //Random rnd = new Random();
            int insertable = 2;
            bool bbreak;
            //bool filled = false;

            while (insertable < 10)
                for (int a = 0; a < 9; a++)
                {
                    bbreak = false;
                    for (int b = 0; b < 9; b++)
                    {
                        if (GameField[a, b] == 0 && GameFieldValid[a, b, 9] == 1)
                        {
                            int insertval = 0; ;
                            for (int c = 0; c < 9; c++)
                            {
                                if (GameFieldValid[a, b, c] != 0)
                                {
                                    insertval = GameFieldValid[a, b, c];
                                    insertable = 2;
                                    break;
                                }
                            }
                            SudokuValidation.setGameFieldValid(GameFieldValid, GameField, a, b, insertval, false);
                            GameField[a, b] = insertval;
                            bbreak = true;
                            break;
                        }
                        //else if (GameFieldValid[a, b, 9] == insertable)
                        //{
                        //    ArrayList AList = new ArrayList;
                        //    AList += 
                        //}
                        //else
                        //    ++insertable;
                    }
                    if (bbreak) break;
                }
            

        }
    }
}

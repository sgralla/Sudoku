using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class SudokuValidation
    {

        public static void initValid(int[,] GameField,int[,,] GameFieldValid)
        {
            //int[,,] GameFieldValid = new int[9, 9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        GameFieldValid[i, j, k] = k + 1;
                    }
                    GameFieldValid[i, j, 9] = 9;
                }
            }
        }

        public static void updateValid(int[,] GameField, int[,,] GameFieldValid, object sender)
        {
            SingleDigitCenteredTextBox Input = (SingleDigitCenteredTextBox)sender;
            byte[] Position = new byte[2];

            // GameField[X,Y] - X = Position[0] & Y = Position[1];
            Position = getPosition(GameField, Input);

            int x = Position[0];
            int y = Position[1];

            //if (InsertInput(GameField, sender))
            if (Input.IntValue == GameField[x, y])
            { }    
            else if (Input.Text != "")
            {
                if (setGameFieldValid(GameFieldValid, GameField, x, y, Input.IntValue, true))
                    GameField[x, y] = Input.IntValue;
                else

                {
                    GameField[x, y] = 0;
                    Input.Text = "";
                }

            }
            else
            {
                if (GameField[x, y] != 0)
                {
                    if (setGameFieldValid(GameFieldValid, GameField, x, y, GameField[x, y], false))
                    {
                        GameField[x, y] = 0;
                        Input.Text = "";
                    }
                }
            }

        }

        internal static void updateCounter(int[,,] GameFieldValid,int x, int y)
        {
            int ValidCounter = 0;
            for (int i = 0; i < 9; i++)
            {
                if (GameFieldValid[x,y,i] != 0)
                    ++ValidCounter;
            }
            GameFieldValid[x, y, 9] = ValidCounter;
        }

        internal static bool setGameFieldValid(int[,,] GameFieldValid, int[,] GameField, int x, int y, int Input, bool remove)
        {
            int insertValidValue;

            insertValidValue = remove ? 0 : Input;


            if (!remove || GameFieldValid[x, y, Input - 1] == Input)
            {
                GameFieldValid[x, y, Input - 1] = insertValidValue;

                for (int i = 0; i < 9; i++)
                {
                    GameFieldValid[i, y, Input - 1] = insertValidValue;
                    updateCounter(GameFieldValid, i, y);
                    GameFieldValid[x, i, Input - 1] = insertValidValue;
                    updateCounter(GameFieldValid, x, i);
                }

                int x0 = x - x % 3;
                int y0 = y - y % 3;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        GameFieldValid[i + x0, j + y0, Input - 1] = insertValidValue;
                        updateCounter(GameFieldValid, i+x0, j+y0);
                    }
                }
                
                return true;
            }
            return false;
        }


        internal static byte[] getPosition(int[,] gameField, SingleDigitCenteredTextBox Input)
        {
            byte[] Position = new byte[2];
            String InputName;
            byte x, y;
            InputName = Input.Name;
            x = Byte.Parse(InputName.Substring(3, 1));
            y = Byte.Parse(InputName.Substring(4, 1));
            --x;

            --y;

            Position[0] = x;
            Position[1] = y;
            return Position;
        }

        // Not required because an empty SDC will set the array value to 0
        internal static void clearField(int[,] GameArray, object sender)
        {
            SingleDigitCenteredTextBox Input = (SingleDigitCenteredTextBox)sender;
      
            byte[] Position = new byte[2];
            Position = getPosition(GameArray, Input);
            GameArray[Position[0],Position[1]] = 0;
        }
    }
}

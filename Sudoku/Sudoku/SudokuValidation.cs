using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class SudokuValidation
    {
        public static String checkInput(int[,] GameField, object sender)
        {
            String Message;
            if (!InsertInput(GameField, sender))
            {
                Message = ("Ungültige Zahl eingegeben.");
                SingleDigitCenteredTextBox sdc = (SingleDigitCenteredTextBox)sender;
                sdc.Text = "";
            }
            else
                Message = "Gültige Zahl eingeben.";

            return Message;


        }

        private static bool InsertInput(int[,] GameField, object sender)
        {
            SingleDigitCenteredTextBox Input = (SingleDigitCenteredTextBox)sender;
            byte x = 0 , y = 0;
            int InputValue;
            bool checkRow, checkColumn, checkSquare;
            byte[] Position = new byte[2];

            
            Position = getPosition(GameField, Input);

            InputValue = Input.IntValue;
            checkRow = true;
            checkColumn = true;
            checkSquare = true;


            if (validateInput(Position[0], Position[1], GameField, InputValue, checkRow, checkColumn, checkSquare))
            {
                GameField[x, y] = InputValue;
                return true;
            }
            return false;
        }

        private static byte[] getPosition(int[,] gameField, SingleDigitCenteredTextBox Input)
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

        internal static void clearField(int[,] GameArray, object sender)
        {
            SingleDigitCenteredTextBox Input = (SingleDigitCenteredTextBox)sender;
      
            byte[] Position = new byte[2];
            Position = getPosition(GameArray, Input);
        }

        public static bool validateInput(int x, int y, int[,] GameField, int Input, bool checkRow, bool checkColumn, bool checkSquare)
        {
            bool valid = true;

            // CheckRow
            if (valid && checkRow && (Input != 0))
                for (int i = 0; i < 9; i++)
                {
                    if (GameField[x, i] == Input)
                    {
                        valid = false;
                        // no need to check any further
                        break;
                    }
                }
            
             
            
            // Check Column
            if (valid && checkColumn)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (GameField[i, y] == Input)
                    {
                        valid = false;
                        // no need to check any further
                        break;
                    }
                }
            }
            // Check square

            if (valid && checkSquare)
            {
                //int[] SquareAsRow = new int[9];
                //SquareAsRow = getSquareAsRow(GameField, x, y);

                ////for (int i = 0; i < 9; i++)
                ////{
                ////    if (SquareAsRow[i] == Input)
                ////        valid = false;
                ////}

                //// just copied this and modified it a little bit
                //// not sure how it works
                //// or will be an improvement
                //valid = !Array.Exists(SquareAsRow, delegate (int s) { return s.Equals(Input); });

                valid = checkSquareFunction(GameField, x, y, Input);
            }
            return valid;
        }

        private static int[] getSquareAsRow(int[,] GameField, int x, int y)
        {
            // Instead of creating an array to easyly check I should check the GameField directly
            int[] SquareAsRow = new int[9];

            int x0 = x - x % 3;
            int y0 = y - y % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SquareAsRow[(i*3+j)] = GameField[i+x0, j+y0];
                }
            }
            return SquareAsRow;
        }

        private static bool checkSquareFunction(int[,] GameField, int x, int y, int Input)
        {
            // Instead of creating an array to easyly check I should check the GameField directly
            //int[] SquareAsRow = new int[9];

            int x0 = x - x % 3;
            int y0 = y - y % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // = GameField[i + x0, j + y0];
                    if (GameField[i + x0, j + y0] == Input)
                        return false;
                }
            }
            //return SquareAsRow;
            return true;
        }
    }
}

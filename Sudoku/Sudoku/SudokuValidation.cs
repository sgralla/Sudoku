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
            //byte x = 0 , y = 0; //Now Position[0], Position[1];
            int InputValue;
            bool checkRow, checkColumn, checkSquare;
            byte[] Position = new byte[2];

            // GameField[X,Y] - X = Position[0] & Y = Position[1];
            Position = getPosition(GameField, Input);

            InputValue = Input.IntValue;
            checkRow = true;
            checkColumn = true;
            checkSquare = true;


            if (validateInput(Position[0], Position[1], GameField, InputValue, checkRow, checkColumn, checkSquare))
            {
                GameField[Position[0], Position[1]] = InputValue;
                return true;
            }
            return false;
        }

        internal static int getNumberOfEmptyFields(int[,] GameArray)
        {
            int counter = 0;
            foreach (int GFV in GameArray)
            {
                if (GFV == 0)
                    ++counter;
            }
            return counter;
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

        public static bool validateInput(int x, int y, int[,] GameField, int Input, bool checkRow, bool checkColumn, bool checkSquare)
        {
            bool valid = true;
            
            // Empty SDC.Text will be set to 0
            // which is always allowed so no need to check
            if (Input != 0)
            {
                // CheckRow
                if (valid && checkRow)
                {
                    valid = checkRowFunction(GameField, x, y, Input);
                }


                // Check Column
                if (valid && checkColumn)
                {
                     valid = checkColumnFunction(GameField, x , y, Input);
                }
                
                // Check square
                if (valid && checkSquare)
                {
                    //// just copied this and modified it a little bit
                    //// not sure how it works
                    //// or will be an improvement
                    //valid = !Array.Exists(SquareAsRow, delegate (int s) { return s.Equals(Input); });

                    valid = checkSquareFunction(GameField, x, y, Input);
                }
            }
            return valid;
        }

        private static bool checkRowFunction(int[,] GameField, int x, int y, int Input)
        {
            for (int i = 0; i < 9; i++)
            {
                if (GameField[x, i] == Input && i != y)
                    return false;
            }
            return true;
        }

        private static bool checkColumnFunction(int [,] GameField, int x, int y, int Input)
        {
            for (int i = 0; i < 9; i++)
            {
                if (GameField[i, y] == Input && i != x)
                    return false;
            }
            return true;
        }

        private static bool checkSquareFunction(int[,] GameField, int x, int y, int Input)
        {
            int x0 = x - x % 3;
            int y0 = y - y % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // = GameField[i + x0, j + y0];
                    if (GameField[i + x0, j + y0] == Input && (i + x0) != x && (j + y0) != y)
                        return false;
                }
            }
            //return SquareAsRow;
            return true;
        }

    }
}

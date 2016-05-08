﻿using System;
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
            String InputName;
            byte x, y;
            int InputValue;
            

            SingleDigitCenteredTextBox Input = (SingleDigitCenteredTextBox)sender;

            InputName = Input.Name;
            x = Byte.Parse(InputName.Substring(3, 1));
            y = Byte.Parse(InputName.Substring(4, 1));
            --x;
            --y;

            InputValue = Input.IntValue;


            if (validateInput(x, y, GameField, InputValue))
            {
                GameField[x, y] = InputValue;
                return true;
            }
            return false;
        }

        private static bool validateInput(int x, int y, int[,] GameField, int Input)
        {
            bool result = true;

            // CheckRow
            for (int i = 0; i < 9; i++)
            {
                if (GameField[x, i] == Input && i != y)
                    result = false;
            }

            // Check Column
            if (result)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (GameField[i, y] == Input && i != x)
                        result = false;
                }
            }
            // Check square

            if (result)
            {
                int[] SquareAsRow = new int[9];
                SquareAsRow = getSquareAsRow(GameField, x, y);
                for (int i = 0; i < 9; i++)
                {
                    if (SquareAsRow[i] == Input)
                        result = false;
                }
            }
            return result;
        }

        private static int[] getSquareAsRow(int[,] GameField, int x, int y)
        {
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
    }
}

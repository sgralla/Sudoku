using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class SudokuBoard
    {
        public static void generateSolution(int[,] GameField)
        {
            //foreach (int Field in GameField)
            int resets = 0;
            int resetcounter = 200;
            int fieldreached = 0;
            int highestreached = 0;

            bool filled = false;
            bool NeedToCheck;
            bool checkRow = false;
            
            while (!filled)
            {
                NeedToCheck = true;
                // replaced by array.clear function
                //for (int i = 0; i < 9; ++i)
                //{
                //    for (int j = 0; j < 9; ++j)
                //    {
                //        GameField[i, j] = 0;
                //    }
                //}
                // Maybe just clear the current row instead of a restart ??
                Array.Clear(GameField,0,fieldreached);
                fieldreached = 0;

                for (int i = 0; i < 9; ++i)
                {
                    ArrayList RowList = new ArrayList();

                    // Use function to generate
                    // Should not be generated everytime
                    // instead copied from or better create an instance of
                    for (int n = 1; n <= 9; n++)
                    {
                        RowList.Add(n);
                    }

                    //RowList.Add(1);
                    //RowList.Add(2);
                    //RowList.Add(3);
                    //RowList.Add(4);
                    //RowList.Add(5);
                    //RowList.Add(6);
                    //RowList.Add(7);
                    //RowList.Add(8);
                    //RowList.Add(9);

                    for (int j = 0; j < 9; ++j)
                    {
                        bool ValidInsert = false;
                        ArrayList FieldList = RowList;


                        while (!ValidInsert)
                        {
                            int InputNumber;

                            Random rnd = new Random();
                            if (FieldList.Count == 0)
                            {
                                NeedToCheck = false;
                                break;
                            }
                              

                            int Number = rnd.Next(0, RowList.Count);
                            
                            int[] InpNum = new int[FieldList.Count];
                            FieldList.CopyTo(InpNum);
                            InputNumber = InpNum[Number];


                            if (SudokuValidation.validateInput(i, j, GameField, InputNumber, checkRow))
                            {
                                ValidInsert = true;
                                GameField[i, j] = InputNumber;
                                RowList.Remove(InputNumber);
                                ++fieldreached;
                            }
                            else
                            {
                                FieldList.Remove(InputNumber);

                                if (FieldList.Count == 0)
                                {
                                    NeedToCheck = false;
                                    ++resets;
                                    // performance check
                                    /**/

                                    if (fieldreached > highestreached) highestreached = fieldreached;

                                    if (resets == resetcounter)
                                    {
                                        Console.WriteLine(resets+ " " + fieldreached + " " + highestreached + " ");
                                        resetcounter += resetcounter;
                                    }
                                    /**/

                                    

                                    break;
                                }
                            }
                            if (!NeedToCheck) break;
                        }
                        if (!NeedToCheck) break;

                    }
                    if (!NeedToCheck) break;
                }
                filled = true;
                if (NeedToCheck)
                {
                    for (int i = 0; i < 9; ++i)
                    {
                        for (int j = 0; j < 9; ++j)
                        {
                            if (GameField[i, j] != 0)
                                filled = false;
                        }
                    }
                }
                else
                    filled = false;
            }
        }
    }
}

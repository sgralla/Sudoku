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
            bool filled = false;
            bool NeedToCheck;
            bool checkRow = false;
            
            while (!filled)
            {
                NeedToCheck = true;
                for (int i = 0; i < 9; ++i)
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        GameField[i, j] = 0;
                    }
                }
                for (int i = 0; i < 9; ++i)
                {
                    ArrayList NAL = new ArrayList();

                    // Use function to generate
                    for (int n = 0; n < 9; n++)
                    {
                        NAL.Add(n);
                    }

                    //NAL.Add(1);
                    //NAL.Add(2);
                    //NAL.Add(3);
                    //NAL.Add(4);
                    //NAL.Add(5);
                    //NAL.Add(6);
                    //NAL.Add(7);
                    //NAL.Add(8);
                    //NAL.Add(9);

                    for (int j = 0; j < 9; ++j)
                    {
                        bool ValidInsert = false;
                        
                        while (!ValidInsert)
                        {
                            int InputNumber;

                            Random rnd = new Random();
                            if (NAL.Count == 0)
                            {
                                NeedToCheck = false;
                                break;
                            }
                              

                            int Number = rnd.Next(0, NAL.Count);
                            
                            int[] InpNum = new int[NAL.Count];
                            NAL.CopyTo(InpNum);
                            InputNumber = InpNum[Number];


                            if (SudokuValidation.validateInput(i, j, GameField, InputNumber, checkRow))
                            {
                                ValidInsert = true;
                                GameField[i, j] = InputNumber;
                                NAL.Remove(InputNumber);
                            }
                            else
                            {
                                NAL.Remove(InputNumber);

                                if (NAL.Count == 0)
                                {
                                    NeedToCheck = false;
                                    ++resets;
                                    // performance check
                                    /*
                                    if (resets == 200)
                                        Console.WriteLine(resets);
                                    */
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

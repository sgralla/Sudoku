﻿using System;
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
                    // New CheckRow only when next row reached
                    ArrayList NAL = new ArrayList();
                    // Not necessary to check anything because a new row should always be empty
                    //int[] CheckRow = new int[9];
                    //for (int r = 0; r < 9; r++)
                    //{
                    //    CheckRow[r] = GameField[i, r];
                    //}

                    //for (int s = 1; s <= 9; s++)
                    //{
                    //    if (!CheckRow.Contains(s))
                    //        NAL.Add(s);
                    //}

                    // Use function to generate
                    NAL.Add(1);
                    NAL.Add(2);
                    NAL.Add(3);
                    NAL.Add(4);
                    NAL.Add(5);
                    NAL.Add(6);
                    NAL.Add(7);
                    NAL.Add(8);
                    NAL.Add(9);

                    for (int j = 0; j < 9; ++j)
                    {
                        bool ValidInsert = false;
                        
                        // ToDo: Only add values which will not fail due being already in the row
                        //ArrayList NAL = new ArrayList();
                        // if (itemp != i)
                        // {
                        // New
                        /*
                             int[] CheckRow = new int[9];
                             for (int r = 0; r < 9; r++)
                             {
                                 CheckRow[r] = GameField[i, r];
                             }

                             for (int s = 1; s <= 9; s++)
                             {
                                 if (!CheckRow.Contains(s))
                                     NAL.Add(s);
                             }
                         //    itemp = i;
                         //}
                         */
                        

                        //OLD
                        /*
                        NAL.Add(1);
                        NAL.Add(2);
                        NAL.Add(3);
                        NAL.Add(4);
                        NAL.Add(5);
                        NAL.Add(6);
                        NAL.Add(7);
                        NAL.Add(8);
                        NAL.Add(9);
                        */

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
                                    if (resets == 200)
                                        Console.WriteLine(resets);
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
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
        public static void generateSolutionRow(int[,] GameField)
        {
            //foreach (int Field in GameField)
            int resets = 0;
            int resetcounter = 200;
            int fieldreached = 0;
            int highestreached = 0;

            bool filled = false;
            bool NeedToCheck;
            bool checkRow = false;
            bool checkColumn = true;
            bool checkSquare = true;
    
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

                        // Needs some rework
                        //FindValidInsert(ValidInsert, RowList, FieldList, NeedToCheck, GameField, fieldreached, highestreached, checkRow, resets, resetcounter, i, j);
                        // outsourced into FindValidInsert Function
                        /**/
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


                            if (SudokuValidation.validateInput(i, j, GameField, InputNumber, checkRow, checkColumn, checkSquare))
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
                                    

                                    if (fieldreached > highestreached) highestreached = fieldreached;

                                    if (resets == resetcounter)
                                    {
                                        Console.WriteLine(resets+ " " + fieldreached + " " + highestreached + " ");
                                        resetcounter += resetcounter;
                                    }
                                    

                                    

                                    break;
                                }
                            }
                            if (!NeedToCheck) break;
                        }
                        /**/
                        if (!NeedToCheck) break;

                    }
                    if (!NeedToCheck) break;
                }
                // Should not be necessary
                //filled = true;
                //if (NeedToCheck)
                //{
                //    for (int i = 0; i < 9; ++i)
                //    {
                //        for (int j = 0; j < 9; ++j)
                //        {
                //            if (GameField[i, j] != 0)
                //                filled = false;
                //        }
                //    }
                //}
                //else
                //    filled = false;
            }
        }

        public static void generateSolutionSquare(int[,] GameField)
        {
            int SquareNumber = 0;
            int highestsquare = 0;

            ArrayList NumberList = generateNumberList();

            while (SquareNumber < 9)
            {
                SquareNumber = FillSquare(NumberList, GameField, SquareNumber) ? +1 : -1;
                if (SquareNumber > highestsquare)
                {
                    highestsquare = SquareNumber;
                    Console.WriteLine(highestsquare + 1);
                }
                
            }
        }

        private static ArrayList generateNumberList()
        {
            ArrayList NumberList = new ArrayList();

            // Use function to generate
            // Should not be generated everytime
            // instead copied from or better create an instance of
            for (int n = 1; n <= 9; n++)
            {
                NumberList.Add(n);
            }
            return NumberList;
        }

        private static bool FillSquare(ArrayList NumberList, int[,] GameField, int SquareNumber)
        {
            int[,] Square = new int[3,3];
            //bool filled = false;
            bool ValidInsertFound = false;
            int InputNumber;
            int ii, jj;
            Random rnd = new Random();

            ArrayList FieldList, SquareList;

            //SquareList = NumberList;
            SquareList = generateNumberList();


            int[] SquareAsRow = new int[9];

            //int x0 = x - x % 3;
            //int y0 = y - y % 3;

            int i0 = (SquareNumber % 3) * 3;
            int j0 = (SquareNumber - SquareNumber%3) * 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    FieldList = SquareList;
                    ValidInsertFound = false;
                    while (FieldList.Count != 0 && !ValidInsertFound)
                    {
                        
                        ii = i + i0;
                        jj = j + j0;

                        int Number = rnd.Next(0, FieldList.Count);

                        int[] InpNum = new int[FieldList.Count];
                        FieldList.CopyTo(InpNum);
                        InputNumber = InpNum[Number];
                        // ValidInsertFound = SudokuValidation.validateInput(i, j, GameField, InputNumber, checkRow, checkColumn, checkSquare)
                        ValidInsertFound = SudokuValidation.validateInput(ii, jj, GameField, InputNumber, true, true, false);
                        if (ValidInsertFound)
                        {
                            GameField[i + i0, j + j0] = InputNumber;
                            SquareList.Remove(InputNumber);
                        }
                        else
                        {
                            FieldList.Remove(InputNumber);
                        }
                    }
                }
            }
            return SquareList.Count == 0;
        }

        public static void generateSmartSolutionRow(int[,] GameField)
        {
            int solved;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //GameField[i,j] = getNumberForRow(GameField, i, j);
                    solved = getNumberForRow(GameField, i, j);
                    GameField[i, j] = solved;
                    Console.Write(solved + " ");
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
                CPos = 0;
                //RPos = 0;
                for (int j = y; j < 9; j++)
                {
                    if (SudokuValidation.validateInput(x, y, GameField, i, true, true, true))
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
            return RNumber;
        }
    }
}

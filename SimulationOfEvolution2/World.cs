using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimulationOfEvolution2
{
    public class World
    {
        Cell[][] CellMap;
        public World(int Column, int Line)
        {
            CellMap = new Cell[Column][];
            for (int i = 0; i < CellMap.Length; i++)
            {
                CellMap[i] = new Cell[Line];
            }
            for (int i = 0; i < CellMap.Length; i++)
                for(int j = 0; j < CellMap[i].Length; j++)
                {
                    if (i == j) CellMap[i][j] = new Cell();
                }
        }

        public void Print(Graphics G)
        {
            for (int i = 0; i < CellMap.Length; i++)
                for (int j = 0; j < CellMap[i].Length; j++)
                {
                    if (CellMap[i][j] != null) 
                    {
                        G.FillRectangle(Brushes.Green, i * Form1.WIDTHCELL, j * Form1.HIGHTCELL, Form1.WIDTHCELL, Form1.HIGHTCELL);
                        G.DrawRectangle(Pens.Black, i * Form1.WIDTHCELL, j * Form1.HIGHTCELL, Form1.WIDTHCELL, Form1.HIGHTCELL);
                    }
                    else
                    {
                        G.FillRectangle(Brushes.White, i * Form1.WIDTHCELL, j * Form1.HIGHTCELL, Form1.WIDTHCELL, Form1.HIGHTCELL);
                        G.DrawRectangle(Pens.Black, i * Form1.WIDTHCELL, j * Form1.HIGHTCELL, Form1.WIDTHCELL, Form1.HIGHTCELL);
                    }
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacks;

namespace Maze
{
    public class Cell
    {
        public int x, y;
        public Cell() { }
        public Cell(int i, int j)
        {
            x = i;
            y = j;
        }
        public bool isSame(Cell cell)
        {
            return x == cell.x && y == cell.y;
        }
    }
    public class Maze
    {
        private int rows = 0, cols = 0;
        private char[][] store;
        private Cell currentCell, exitCell = new Cell(), entryCell = new Cell();
        private const char EXIT_MARKER = 'e', ENTRY_MARKER = 'm', VISITED = '.';
        private const char PASSAGE = '0', WALL = '1';
        private Stack mazeStack = new ArrayStack(10);

        public Maze(string[] maze)
        {
            int row = 0, col = 0;
            Stack mazeRows = new ArrayStack(10);
            string[] mazeData = maze;

            for (int index = 0; index < mazeData.Length; index++)
            {
                row++;
                mazeData[index] = WALL + mazeData[index] + WALL;
                cols = mazeData[index].Length;
                mazeRows.push(mazeData[index]);
                if (mazeData[index].IndexOf(EXIT_MARKER) != -1)
                {
                    exitCell.x = row;
                    exitCell.y = mazeData[index].IndexOf(EXIT_MARKER);
                }
                if (mazeData[index].IndexOf(ENTRY_MARKER) != -1)
                {
                    entryCell.x = row;
                    entryCell.y = mazeData[index].IndexOf(ENTRY_MARKER);
                }
            }

            rows = row;
            store = new char[rows + 2][];
            store[0] = new char[cols];
            for (; !mazeRows.isEmpty(); row--)
            {
                store[row] = ((string)mazeRows.pop()).ToCharArray();
            }
            store[rows + 1] = new char[cols];
            for (col = 0; col < cols; col++)
            {
                store[0][col] = WALL;
                store[rows + 1][col] = WALL;
            }
        }

        private void display()
        {
            for (int row = 0; row <= rows + 1; row++)
            {
                Console.WriteLine(store[row]);
            }
            Console.WriteLine();
        }

        private void pushUnvisited(int row, int col)
        {
            if (store[row][col] == PASSAGE || store[row][col] == EXIT_MARKER)
            {
                mazeStack.push(new Cell(row, col));
            }
        }

        public void exitMaze()
        {
            currentCell = entryCell;
            Console.WriteLine(entryCell);
            Console.WriteLine(currentCell.isSame(exitCell));
            Console.WriteLine();
            while (!currentCell.isSame(exitCell))
            {
                int row = currentCell.x;
                int col = currentCell.y;
                Console.WriteLine(row+""+ col);
                display();
                // TODO
                pushUnvisited(row-1,col );
                pushUnvisited(row , col-1);
                pushUnvisited(row +1, col);
                pushUnvisited(row, col + 1);
                Console.WriteLine(mazeStack.peek());
                currentCell =(Cell) mazeStack.pop();
                store[currentCell.x][currentCell.y] = '.';
            }
            display();
            Console.WriteLine("Success");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            (new Maze(new string[]{
                "000010",
                "0111e0",
                "01110m",
                "000001"
            })).exitMaze();
            Console.ReadLine();
        }
    }
}

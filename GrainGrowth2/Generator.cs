using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GrainGrowthCore;
using GrainGrowthCore.Neighborhoods;

namespace GrainGrowth2
{
	static class Generator
	{
		static Random random = new Random();

		public static bool GenerateRandomBoard(int amount, Cell[,] board, int numberOfTries = 10000)
		{

			List<int> setX = new List<int>();
			List<int> setY = new List<int>();
			for (int i = 0; i < amount; i++)
			{
				int x = random.Next(board.GetLength(0) - 1);
				int y = random.Next(board.GetLength(1) - 1);
				int counter = numberOfTries;
				while (counter > 0 && !board[x,y].Grain.IsEmpty() && (setX.Contains(x) && setY.Contains(y)))
				{
					x = random.Next(board.GetLength(0) - 1);
					y = random.Next(board.GetLength(1) - 1);
					counter--;
				}
				if (counter > 0)
				{
					setX.Add(x);
					setY.Add(y);
				}
				else
				{
					break;
				}
			}

			for (int i = 0; i < setX.Count; i++)
			{
				int x = setX.ElementAt(i);
				int y = setY.ElementAt(i);
				board[x, y].SetGrain(new Grain());
			}
			if (setX.Count == amount)
				return true;
			else
				return false;
		}
		public static bool GenerateRandomInclusions(DrawableCell[,] board, Neighborhood neighborhood, int number, int size, int type, bool simulationDone, int numberOfTries = 10000)
		{
			List<int> setX = new List<int>();
			List<int> setY = new List<int>();
			for (int i = 0; i < number; i++)
			{
				int x = random.Next(board.GetLength(0) - 1);
				int y = random.Next(board.GetLength(1) - 1);
				int counter = numberOfTries;
				while (counter > 0 && !board[x, y].Grain.IsInjection() && ((setX.Contains(x) && setY.Contains(y)) || (simulationDone && !neighborhood.IsBorder(board,x,y,BoundaryCondition.NormalBoundary))))
				{
					x = random.Next(board.GetLength(0) - 1);
					y = random.Next(board.GetLength(1) - 1);
					counter--;
				}
				if (counter > 0)
				{
					setX.Add(x);
					setY.Add(y);
				}
				else
				{
					break;
				}
			}

			int xMax = board.GetLength(0);
			int yMax = board.GetLength(1);


			for (int i = 0; i < setX.Count; i++)
			{
				int x = setX.ElementAt(i);
				int y = setY.ElementAt(i);
				if (type == 1)
				{
					int xFrom = x - size < 0 ? 0 : x - size;
					int xto = x + size >= xMax ? xMax - 1 : x + size;
					int yFrom = y - size < 0 ? 0 : y - size;
					int yto = y + size >= yMax ? yMax - 1 : y + size;

					for (int j = xFrom; j < xto; j++)
					{
						for (int k = yFrom; k < yto; k++)
						{
							board[j, k].SetGrain(Grain.InjectionGrain);
						}
					}
				}
				else if (type == 0)
				{
					int cellsize = board[x, y].Rectangle.Width;
					int r = size * cellsize;
					Point sr = new Point(board[x, y].Rectangle.X + cellsize / 2, board[x, y].Rectangle.Y + cellsize / 2);

					for (var k = 0; k < board.GetLength(0); k++)
						for (var m = 0; m < board.GetLength(1); m++)
						{
							Point temp = new Point(board[k, m].Rectangle.X + cellsize / 2, board[k, m].Rectangle.Y + cellsize / 2);
							if (Math.Sqrt(Math.Pow(temp.X - sr.X, 2) + Math.Pow(temp.Y - sr.Y, 2)) < r)
								board[k, m].SetGrain(Grain.InjectionGrain); ;
						}
				}
			}
			if (setX.Count == number)
				return true;
			else
				return false;
		}

	}
}

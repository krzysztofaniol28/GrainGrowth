using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrainGrowthCore.Neighborhoods;

namespace GrainGrowthCore
{
	public class Grid
	{
		private readonly Cell[,] board;
		private int sizeX => board.GetLength(0);
		private int sizeY => board.GetLength(1);
		private readonly Neighborhood neighborhood;
		private readonly BoundaryCondition boundaryCodition;

		public Grid(Cell[,] board, Neighborhood neighborhood, BoundaryCondition boundaryCodition)
		{
			this.board = board;
			this.neighborhood = neighborhood;
			this.boundaryCodition = boundaryCodition;
		}

		public void SelectAllBoundaries()
		{
			Cell[,] nextBoard = InitBoard();
			for (int i = 0; i < sizeX; i++)
			{
				for (int j = 0; j < sizeY; j++)
				{
					if (!board[i,j].Grain.IsEmpty() && !board[i, j].Grain.IsInclusion() && neighborhood.IsBorder(board, i, j, BoundaryCondition.NormalBoundary))
					{
						nextBoard[i, j].SetGrain(Grain.InjectionGrain);
					}
					else
					{
						nextBoard[i, j].SetGrain(Grain.EmptyGrain);

					}
				}

			}
			SetNextState(nextBoard);
		}

		public void GrowGrains(int max = 800)
		{
			Cell[,] nextBoard = InitBoard();
			int count;
			do
			{
				count = 0;
				for (int i = 0; i < sizeX; i++)
				{
					for (int j = 0; j < sizeY; j++)
					{
						if (board[i, j].Grain.IsEmpty())
						{
							var grain = neighborhood.GetLivingNeighbors(board, i, j, boundaryCodition);
							if (!grain.IsEmpty() && nextBoard[i, j].SetGrain(grain))
								++count;
						}
					}
				}
				SetNextState(nextBoard);
				--max;
				Console.WriteLine(max);
			}
			while (max > 0 && (count != 0 || AnyEmptyCell(board)));
		}

		private bool AnyEmptyCell(Cell[,] board)
		{
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					if (board[i, j].Grain.IsEmpty())
						return true;
				}
			}
			return false;
		}

		private Cell[,] InitBoard()
		{
			Cell[,] board = new Cell[sizeX, sizeY];
			for (int i = 0; i < sizeX; i++)
				for (int j = 0; j < sizeY; j++)
					board[i, j] = new Cell();
			return board;
		}


		private void SetNextState(Cell[,] nextGrid)
		{
			for (int i = 0; i < sizeX; i++)
				for (int j = 0; j < sizeY; j++)
					board[i, j].SetGrain(nextGrid[i, j].Grain);
		}

		public void ClearActiveGrains()
		{
			for (int i = 0; i < sizeX; i++)
			{
				for (int j = 0; j < sizeY; j++)
				{
					if(!board[i, j].Grain.IsInclusion())
						board[i, j].ClearGrain();
				}
			}
		}
	}
}

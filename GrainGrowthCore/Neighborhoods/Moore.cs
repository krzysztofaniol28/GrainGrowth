using GrainGrowthCore.TrancisionRules;
using System.Collections.Generic;

namespace GrainGrowthCore.Neighborhoods
{
	public class Moore: Neighborhood
	{
		public Moore(ITrancisionRule trancisionRule):base(trancisionRule)
		{
		}

		public override Grain GetLivingNeighbors(Cell[,] grid, int i, int j, BoundaryCondition boundary)
		{
			List<Grain> list = new List<Grain>();
			list.Add(GetRight(grid, i, j, boundary));
			list.Add(GetBottomRight(grid, i, j, boundary));
			list.Add(GetBottom(grid, i, j, boundary));
			list.Add(GetBottomLeft(grid, i, j, boundary));
			list.Add(GetLeft(grid, i, j, boundary));
			list.Add(GetTopLeft(grid, i, j, boundary));
			list.Add(GetTop(grid, i, j, boundary));
			list.Add(GetTopRight(grid, i, j, boundary));

			return TrancisionRule.GetWinningGrain(list);
		}

		public override bool IsBorder(Cell[,] grid, int i, int j, BoundaryCondition boundary)
		{
			var activeGrain = grid[i, j].Grain;
			if (GetRight(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetBottomRight(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetBottom(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetBottomLeft(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetLeft(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetTopLeft(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetTop(grid, i, j, boundary) != activeGrain)
				return true;
			if (GetTopRight(grid, i, j, boundary) != activeGrain)
				return true;

			return false;
		}
	}
}

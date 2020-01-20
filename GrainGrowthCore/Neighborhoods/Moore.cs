using GrainGrowthCore.TrancisionRules;
using System.Collections.Generic;
using System.Linq;

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
			var neighbors = new List<Grain>()
			{
				GetRight(grid, i, j, boundary),
				GetBottomRight(grid, i, j, boundary),
				GetBottom(grid, i, j, boundary),
				GetBottomLeft(grid, i, j, boundary),
				GetLeft(grid, i, j, boundary),
				GetTopLeft(grid, i, j, boundary),
				GetTop(grid, i, j, boundary),
				GetTopRight(grid, i, j, boundary),
			};
			return neighbors.Any(x => x != activeGrain && !x.IsInclusion());
		}
	}
}

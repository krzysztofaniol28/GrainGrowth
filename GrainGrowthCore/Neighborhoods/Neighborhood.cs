using GrainGrowthCore.TrancisionRules;
using System.Collections.Generic;
using System.Linq;

namespace GrainGrowthCore.Neighborhoods
{
    public abstract class Neighborhood
    {
        public ITrancisionRule TrancisionRule { get; set; }
        public Neighborhood(ITrancisionRule trancisionRule)
        {
            TrancisionRule = trancisionRule;
        }
        public abstract Grain GetLivingNeighbors(Cell[,] grid, int i, int j, BoundaryCondition boundary);
        public abstract bool IsBorder(Cell[,] grid, int i, int j, BoundaryCondition boundary);

        protected Grain GetRight(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (i != grid.GetLength(0) - 1)
                return grid[i + 1, j].Grain;
            else if (boundary == BoundaryCondition.Periodic)
                return grid[0, j].Grain;
            else
                return Grain.EmptyGrain;
        }

        protected Grain GetBottomRight(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (i != grid.GetLength(0) - 1 && j != grid.GetLength(1) - 1)
                return grid[i + 1, j + 1].Grain;
            else if (boundary == BoundaryCondition.Periodic)
            {
                if (i == grid.GetLength(0) - 1 && j == grid.GetLength(1) - 1)
                    return grid[0, 0].Grain;
                else if (i == grid.GetLength(0) - 1)
                    return grid[0, j + 1].Grain;
                else
                    return grid[i + 1, 0].Grain;
            }
            else
                return Grain.EmptyGrain;
        }

        protected Grain GetBottom(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (j != grid.GetLength(1) - 1)
                return grid[i, j + 1].Grain;
            else if (boundary == BoundaryCondition.Periodic)
                return grid[i, 0].Grain;
            else
                return Grain.EmptyGrain;

        }

        protected Grain GetBottomLeft(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (i != 0 && j != grid.GetLength(1) - 1)
                return grid[i - 1, j + 1].Grain;
            else if (boundary == BoundaryCondition.Periodic)
            {
                if (i == 0 && j == grid.GetLength(1) - 1)
                    return grid[grid.GetLength(0) - 1, 0].Grain;
                else if (i == 0)
                    return grid[grid.GetLength(0) - 1, j + 1].Grain;
                else
                    return grid[i - 1, 0].Grain;
            }
            else
                return Grain.EmptyGrain;
        }

        protected Grain GetLeft(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (i != 0)
                return grid[i - 1, j].Grain;
            else if (boundary == BoundaryCondition.Periodic)
                return grid[grid.GetLength(0) - 1, j].Grain;
            else
                return Grain.EmptyGrain;
        }

        protected Grain GetTopLeft(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (i != 0 && j != 0)
                return grid[i - 1, j - 1].Grain;
            else if (boundary == BoundaryCondition.Periodic)
            {
                if (i == 0 && j == 0)
                    return grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1].Grain;
                else if (i == 0)
                    return grid[grid.GetLength(0) - 1, j - 1].Grain;
                else
                    return grid[i - 1, grid.GetLength(1) - 1].Grain;
            }
            else
                return Grain.EmptyGrain;
        }

        protected Grain GetTop(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (j != 0)
                return grid[i, j - 1].Grain;
            else if (boundary == BoundaryCondition.Periodic)
                return grid[i, grid.GetLength(1) - 1].Grain;
            else
                return Grain.EmptyGrain;
        }

        protected Grain GetTopRight(Cell[,] grid, int i, int j, BoundaryCondition boundary)
        {
            if (i != grid.GetLength(0) - 1 && j != 0)
                return grid[i + 1, j - 1].Grain;
            else if (boundary == BoundaryCondition.Periodic)
            {
                if (i == grid.GetLength(0) - 1 && j == 0)
                    return grid[0, grid.GetLength(1) - 1].Grain;
                else if (i == grid.GetLength(0) - 1)
                    return grid[0, j - 1].Grain;
                else
                    return grid[i + 1, grid.GetLength(1) - 1].Grain;
            }
            else
                return Grain.EmptyGrain;
        }

    }
}

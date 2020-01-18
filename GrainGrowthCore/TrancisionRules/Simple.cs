using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainGrowthCore.TrancisionRules
{
	public class Simple : ITrancisionRule
	{
		public Grain GetWinningGrain(List<Grain> neighbors)
        {
            neighbors.RemoveAll(a => !a.CanGrow());
            if (neighbors.Any())
            {
                var result = neighbors.GroupBy(a => a).Select(group => new
                {
                    Number = group.Key,
                    Frequency = group.Count()
                }).OrderByDescending(b => b.Frequency).First().Number;
                return result;
            }
            else
                return Grain.EmptyGrain;
        }
	}
}

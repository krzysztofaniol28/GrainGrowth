using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainGrowthCore.TrancisionRules
{
	public interface ITrancisionRule
	{
		Grain GetWinningGrain(List<Grain> neighbors);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainGrowthCore.TrancisionRules
{
	public class ShapeControl : ITrancisionRule
	{
		private double probability;
		private Random random = new Random();

		public ShapeControl(double probability)
		{
			this.probability = probability;
		}

		public Grain GetWinningGrain(List<Grain> neighbors)
		{
			if (GetMostFrequentGrain(neighbors).grain.IsEmpty())
				return Grain.EmptyGrain;


			Grain result = Rule1(neighbors);
			if (!result.IsEmpty())
				return result;

			result = Rule2(neighbors);
			if (!result.IsEmpty())
				return result;

			result = Rule3(neighbors);
			if (!result.IsEmpty())
				return result;

			result = Rule4(neighbors);
			return result;
		}

		private Grain Rule1(List<Grain> neighbors)
		{
			var mostFrequentGrain = GetMostFrequentGrain(neighbors);
			if (mostFrequentGrain.frequency > 4)
				return mostFrequentGrain.grain;
			else
				return Grain.EmptyGrain;
		}

		private (Grain grain, int frequency) GetMostFrequentGrain(List<Grain> neighbors)
		{
			var tempNeighbors = neighbors.ToList();
			tempNeighbors.RemoveAll(a => 
			!a.CanGrow());
			if (tempNeighbors.Any())
			{
				var result = tempNeighbors.GroupBy(a => a).Select(group => new
				{
					Grain = group.Key,
					Frequency = group.Count()
				}).OrderByDescending(b => b.Frequency).First();
				return (result.Grain, result.Frequency);
			}

			return (Grain.EmptyGrain, 0);
		}

		private Grain Rule2(List<Grain> neighbors)
		{
			var nearestNeighbors = new List<Grain> { neighbors[0], neighbors[2], neighbors[4], neighbors[6] };
			var mostFrequentGrain = GetMostFrequentGrain(nearestNeighbors);
			if (mostFrequentGrain.frequency > 2)
				return mostFrequentGrain.grain;
			else
				return Grain.EmptyGrain;
		}

		private Grain Rule3(List<Grain> neighbors)
		{
			var futherNeighbors = new List<Grain> { neighbors[1], neighbors[3], neighbors[5], neighbors[7] };
			var mostFrequentGrain = GetMostFrequentGrain(futherNeighbors);
			if (mostFrequentGrain.frequency > 2)
				return mostFrequentGrain.grain;
			else
				return Grain.EmptyGrain;
		}

		private Grain Rule4(List<Grain> neighbors)
		{
			var mostFrequentGrain = GetMostFrequentGrain(neighbors);
			var randomValue = random.Next(0, 100);
			if (randomValue < probability)
				return mostFrequentGrain.grain;
			else
				return Grain.EmptyGrain;
		}

		
	}
}

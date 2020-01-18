using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainGrowthCore
{
	public class Grain
	{
		public static int EmptyGrainId = 0;
		public static Grain EmptyGrain => new Grain(EmptyGrainId);

		public static int InclusionGrainId = -1;
		public static Grain InjectionGrain => new Grain(InclusionGrainId);
		public static Grain DualPhaseGrain => new Grain(DualPhaseGrainId) { BlockGrow = true};
		public static int DualPhaseGrainId = 5000;
		public static void Reset() => _lastId = EmptyGrainId;

		private static int _lastId = EmptyGrainId;

		public static List<int> ProtectedIds { get; } = new List<int>() { DualPhaseGrainId };

		public bool BlockGrow { get; set; }

		public int Id { get; }

		public Grain(int id)
		{
			Id = id;
			if (_lastId < id)
				_lastId = id;
		}

		public Grain()
		{
			do
			{
				++_lastId;
			}
			while (ProtectedIds.Contains(_lastId));
			Id = _lastId;
		}

		public bool CanGrow()
		{
			return !IsEmpty() && !IsInclusion() && !BlockGrow;
		}

		public bool IsEmpty()
			=> Id == EmptyGrainId;
		public bool IsInclusion()
			=> Id == InclusionGrainId;

		public override int GetHashCode()
		{
			return Id;
		}

		public override bool Equals(object obj)
		{
			return obj != null && ((Grain)obj).Id == this.Id;
		}
	}
}

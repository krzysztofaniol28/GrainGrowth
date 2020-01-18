using System.IO;
using System.Linq;
using System.Text;
using GrainGrowthCore;

namespace GrainGrowth2
{
	class TextBoardExporter
	{

		public void Export(DrawableCell[,] board, string path)
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine(board.GetLength(0) + "\t" + board.GetLength(0));

			for (var i = 0; i < board.GetLength(0); i++)
				for (var j = 0; j < board.GetLength(1); j++)
					builder.AppendLine(i + "\t"+ j + "\t"+ board[i,j].Grain.Id);

			File.WriteAllText(path, builder.ToString());
		}

		public DrawableCell[,] Import(string path, int cellsize)
		{

			var content = File.ReadAllLines(path);
			var header = content.First().Split('\t');

			var board = new DrawableCell[int.Parse(header[0]), int.Parse(header[1])];
			for (int i = 1; i < content.Length; i++)
			{
				var lineSplit = content[i].Split('\t');
				int x = int.Parse(lineSplit[0]);
				int y = int.Parse(lineSplit[1]);
				int grainId = int.Parse(lineSplit[2]);
				board[x, y] = new DrawableCell(x, y, cellsize, new Grain(grainId));
			}

			return board;
		}
	}
}

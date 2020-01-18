using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using GrainGrowthCore;

namespace GrainGrowth2
{
	class BitmapBoardExporter
	{
		public DrawableCell[,] Import(string path, int cellsize)
		{
			var bitmap = new Bitmap(Image.FromFile(path, true));
			var board = new DrawableCell[bitmap.Width, bitmap.Height];

			for (var i = 0; i < board.GetLength(0); i++)
				for (var j = 0; j < board.GetLength(1); j++)
					board[i, j] = new DrawableCell(i, j, cellsize, DrawableCell.GetGrain(bitmap.GetPixel(i, j)));

			return board;
		}

		public void Export(DrawableCell[,] board, string path)
		{
			var bitmap = new Bitmap(board.GetLength(0), board.GetLength(1));

			for (var i = 0; i < board.GetLength(0); i++)
				for (var j = 0; j < board.GetLength(1); j++)
					bitmap.SetPixel(i, j, board[i, j].GetGrainColor());

			bitmap.Save(path);
		}
	}
}

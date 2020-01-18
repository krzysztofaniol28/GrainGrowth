using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrainGrowthCore;
using GrainGrowthCore.Neighborhoods;
using GrainGrowthCore.TrancisionRules;

namespace GrainGrowth2
{
	public partial class Form1 : Form
	{
		private DrawableCell[,] board;
		private Neighborhood neighborhood = new Moore(new Simple());
		private BoundaryCondition boundaryCondition = BoundaryCondition.NormalBoundary;
		private BufferedGraphics bGraphics;
		private Dictionary<Grain, Grain> structureGrains = new Dictionary<Grain, Grain>();
		private int cellSize = 2;
		private int height = 400;
		private int width = 546;
		private bool simulationDone;
		private bool dualPhaseMouseClickOn ;

		public Form1()
		{
			InitializeComponent();
			algorithmComboBox.SelectedIndex = 0;
			inclusionsTypeComboBox.SelectedIndex = 0;
			structureComboBox.SelectedIndex = 0;
			RedrawGrains();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			SetTransisionRules();
			var grid = new Grid(board, neighborhood, boundaryCondition);
			grid.GrowGrains();
			DrawGrains();
			generationButton.Enabled = false;
			numberOfGrainsTextBox.Enabled = false;
			startButton.Enabled = false;
			simulationDone = true;
			selectGrainButton.Enabled = true;
			getAllBoundariesButton.Enabled = true;
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			ResetState();
			RedrawGrains();
		}


		private void DrawGrains()
		{
			bGraphics.Graphics.ResetTransform();
			for (var i = 0; i < board.GetLength(0); i++)
				for (var j = 0; j < board.GetLength(1); j++)
				{
					board[i, j].Draw(bGraphics.Graphics);
				}
			bGraphics.Graphics.ScaleTransform(2.0f, 2.0f);
			bGraphics.Render();
		}

		private void RedrawGrains()
		{
			BufferedGraphicsContext context = BufferedGraphicsManager.Current;
			bGraphics = context.Allocate(pictureBox1.CreateGraphics(), pictureBox1.DisplayRectangle);

			board = new DrawableCell[width / cellSize, height / cellSize];
			ClearGrains();
		}

		private void ClearGrains()
		{
			for (var i = 0; i < board.GetLength(0); i++)
				for (var j = 0; j < board.GetLength(1); j++)
					board[i, j] = new DrawableCell(i, j, cellSize);
			DrawGrains();
		}

		private void generationButton_Click(object sender, EventArgs e)
		{
			Generator.GenerateRandomBoard(int.Parse(numberOfGrainsTextBox.Text), board);
			DrawGrains();
			startButton.Enabled = true;
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Text|*.txt|Bitmap|*.bmp";
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (openFileDialog.FilterIndex == 1)
						board = new TextBoardExporter().Import(openFileDialog.FileName, cellSize);
					else
						board = new BitmapBoardExporter().Import(openFileDialog.FileName, cellSize);
				}
			}
			DrawGrains();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Text|*.txt|Bitmap|*.bmp";
			saveFileDialog.FilterIndex = 0;
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (saveFileDialog.FilterIndex == 1)
					new TextBoardExporter().Export(board, saveFileDialog.FileName);
				else
					new BitmapBoardExporter().Export(board, saveFileDialog.FileName);
			}
		}

		private void widthTextBox_TextChanged(object sender, EventArgs e)
		{
		}

		private void heigthTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void addInclusionsButton_Click(object sender, EventArgs e)
		{
			int number = int.Parse(numberOfInclusionsTextBox.Text);
			int size = int.Parse(sizeOfInclusionsTextBox.Text);
			int type = inclusionsTypeComboBox.SelectedIndex;

			if (type != -1)
				Generator.GenerateRandomInclusions(board, neighborhood, number, size, type, simulationDone);
			DrawGrains();
		}

		private void redrawButton_Click(object sender, EventArgs e)
		{
			cellSize = int.Parse(cellSizeTextBox.Text);
			width = int.Parse(widthTextBox.Text);
			height = int.Parse(heigthTextBox.Text);
			ResetState();
			RedrawGrains();
		}

		private void ResetState()
		{
			Grain.Reset();
			generationButton.Enabled = true;
			numberOfGrainsTextBox.Enabled = true;
			startButton.Enabled = false;
			simulationDone = false;
			selectGrainButton.Enabled = false;
			structureGrains.Clear();
		}

		private void algorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetTransisionRules();
		}

		private void SetTransisionRules()
		{
			switch (algorithmComboBox.SelectedIndex)
			{
				case 0:
					probabilityTextBox.Enabled = false;
					neighborhood.TrancisionRule = new Simple();
					break;
				case 1:
					probabilityTextBox.Enabled = true;
					double prob = double.Parse(probabilityTextBox.Text);
					if (prob < 0)
						prob = 0;
					if (prob > 100)
						prob = 100;
					neighborhood.TrancisionRule = new ShapeControl(prob);
					break;
			}
		}

		private void selectGrainButton_Click(object sender, EventArgs e)
		{
			if (dualPhaseMouseClickOn)
			{
				for (int i = 0; i < board.GetLength(0); i++)
					for (int j = 0; j < board.GetLength(1); j++)
					{
						if (structureGrains.TryGetValue(board[i, j].Grain, out Grain newGrain))
							board[i, j] = new DrawableCell(i, j, cellSize, newGrain);
						else if(!board[i, j].Grain.IsInclusion())
							board[i, j] = new DrawableCell(i, j, cellSize);
					}

				DrawGrains();
				ResetState();
				dualPhaseMouseClickOn = false;
				selectGrainButton.Text = "Select grains";
			}
			else
			{
				dualPhaseMouseClickOn = true;
				selectGrainButton.Text = "Done";
			}
		}



		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (dualPhaseMouseClickOn)
			{
				var location = ((MouseEventArgs)e).Location;
				var grain = board[location.X / cellSize, location.Y / cellSize].Grain;
				if (!structureGrains.ContainsKey(grain))
				{
					var newGrain = new Grain(grain.Id);
					newGrain.BlockGrow = true;
					if (structureComboBox.SelectedIndex == 0)
						Grain.ProtectedIds.Add(grain.Id);
					else
						newGrain = Grain.DualPhaseGrain;

					structureGrains.Add(grain, newGrain);
				}
			}
		}

		private void getAllBoundariesButton_Click(object sender, EventArgs e)
		{

			var grid = new Grid(board, neighborhood, boundaryCondition);
			grid.SelectAllBoundaries();
			DrawGrains();

			getAllBoundariesButton.Enabled = false;
			clearActiveGrainsButton.Enabled = true;
		}

		private void clearActiveGrainsButton_Click(object sender, EventArgs e)
		{
			var grid = new Grid(board, neighborhood, boundaryCondition);
			grid.ClearActiveGrains();
			DrawGrains();
			ResetState();
			clearActiveGrainsButton.Enabled = false;
		}
	}
}

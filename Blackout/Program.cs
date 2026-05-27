using System;
using Spectre.Console;

namespace Blackout
{
    public class Program
    {
        private static void Main(string[] args)
        {
            View viewer = new View();
            Controller control = new Controller();
            Model model = new Model();

            Console.WriteLine();
            
            var choice = viewer.DifficultySelect();
            var (rows, cols) = control.GridBuilder(choice, viewer);
            var touch = control.DifficultyTouch(choice, viewer);

            viewer.Load(rows, cols);
            var dimensions = model.GridSize(rows, cols);
            control.SquareAssort(dimensions, touch);
            viewer.GridDraw(dimensions);
        }
    }
}
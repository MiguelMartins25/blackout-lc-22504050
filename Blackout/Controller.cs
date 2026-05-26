using System;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Spectre.Console;
using static Blackout.View;

namespace Blackout
{
    public class Controller
    {
        readonly View view = new View();
        public (int, int) GridBuilder()
        {
            if (view.ReturnChoice() == "[green]Easy[/]")
            {
                return (3, 3); 
            }

            else if (view.ReturnChoice() == "[yellow]Medium[/]")
            {
                return (5, 5);
            }

            else if (view.ReturnChoice() == "[red]Hard[/]")
            {
                return (8, 8);
            }

            else if (view.ReturnChoice() == "Custom")
            {
                int r = view.RequestRow();
                int c = view.RequestColumn();
                return (r, c);
            }

            var (rows, columns) = GridBuilder();
            return (rows, columns);
        } 
    }
}

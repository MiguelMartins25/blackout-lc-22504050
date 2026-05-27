using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Spectre.Console;

namespace Blackout
{
    public class Model
    {
        public bool[,] GridSize(int length, int width)
        {
            bool[,] grid = new bool[length, width]; // IA para saber como é que
                                                    // grids são feitas.
            
            return grid;
        }
    }
}
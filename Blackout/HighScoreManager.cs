using System;
using System.Collections.Generic;
using System.IO;

namespace Blackout
{
    public class HighScoreManager
    {
        private const string FileName = "highscores.txt";

        public Dictionary<string, int> LoadScores()
        {
            Dictionary<string, int> scores = new();

            if (!File.Exists(FileName))
            {
                return scores;
            }

            string[] lines = File.ReadAllLines(FileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');

                scores[parts[0]] = int.Parse(parts[1]);
            }

            return scores;
        }

        public void SaveScores(Dictionary<string, int> scores)
        {
            List<string> lines = new();

            foreach (var score in scores)
            {
                lines.Add($"{score.Key}:{score.Value}");
            }

            File.WriteAllLines(FileName, lines);
        }
    }
}
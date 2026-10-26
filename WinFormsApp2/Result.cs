using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WinFormsApp2
{
    internal class Result
    {
        public string Player { get; set; } = "";
        public double Speed { get; set; }
        public double Accuracy { get; set; }
        public string Level { get; set; } = "";
        public DateTime Date { get; set; }
        public double Score => Speed * Accuracy / 100;

        public string ToLine()
        {
            return string.Join(";",
                Player.Replace(";", ","),
                Speed.ToString("0.0", CultureInfo.InvariantCulture),
                Accuracy.ToString("0.0", CultureInfo.InvariantCulture),
                Level,
                Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
        }

        public static Result? FromLine(string line)
        {
            string[] parts = line.Split(';');
            if (parts.Length != 5) return null;

            try
            {
                return new Result
                {
                    Player = parts[0],
                    Speed = double.Parse(parts[1], CultureInfo.InvariantCulture),
                    Accuracy = double.Parse(parts[2], CultureInfo.InvariantCulture),
                    Level = parts[3],
                    Date = DateTime.ParseExact(parts[4], "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
                };
            }
            catch
            {
                return null;
            }
        }
    }
}

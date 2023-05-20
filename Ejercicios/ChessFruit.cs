namespace Ejercicios
{
    public class ChessBoard
    {
        private Dictionary<string, char> fruits;
        private string horsePosition;
        private Dictionary<string, Func<string, string>> moves;

        public ChessBoard()
        {
            fruits = new Dictionary<string, char>();
            moves = new Dictionary<string, Func<string, string>> {
                { "UL", pos => ((char)(pos[0] - 1)).ToString() + (char.Parse(pos[1].ToString()) - 2) },
                { "UR", pos => ((char)(pos[0] - 1)).ToString() + (char.Parse(pos[1].ToString()) + 2) },
                { "LU", pos => ((char)(pos[0] - 2)).ToString() + (char.Parse(pos[1].ToString()) - 1) },
                { "LD", pos => ((char)(pos[0] + 2)).ToString() + (char.Parse(pos[1].ToString()) - 1) },
                { "RU", pos => ((char)(pos[0] - 2)).ToString() + (char.Parse(pos[1].ToString()) + 1) },
                { "RD", pos => ((char)(pos[0] + 2)).ToString() + (char.Parse(pos[1].ToString()) + 1) },
                { "DL", pos => ((char)(pos[0] + 1)).ToString() + (char.Parse(pos[1].ToString()) - 2) },
                { "DR", pos => ((char)(pos[0] + 1)).ToString() + (char.Parse(pos[1].ToString()) + 2) }
            };
        }

        public void SetFruits(string fruitData)
        {
            string[] data = fruitData.Split(',');
            foreach (var datum in data)
            {
                fruits[datum.Substring(1, 2).ToUpper() + datum.Substring(0, 1)] = datum[2];
            }
        }

        public void SetHorsePosition(string position)
        {
            horsePosition = position.Substring(1, 1) + position.Substring(0, 1);
        }

        public string Harvest(string moveData)
        {
            string[] data = moveData.Split(',');
            string result = "";
            foreach (var move in data)
            {
                horsePosition = moves[move.ToUpper()](horsePosition);
                if (fruits.ContainsKey(horsePosition))
                {
                    result += fruits[horsePosition];
                    fruits.Remove(horsePosition);
                }
            }

            return result;
        }
    }
}
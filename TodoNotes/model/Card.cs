using System.Reflection;

namespace model;

public class Card(string todo, int score)
{
    public string Todo { get; set; } = todo;
    public int Score { get; set; } = score;
}
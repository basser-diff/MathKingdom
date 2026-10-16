using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathKingdom.Models;

public class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public int Coins { get; set; }

    public int Score { get; set; }

    public int CurrentLevel { get; set; }
}
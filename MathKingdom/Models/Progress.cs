using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathKingdom.Models;

public class Progress
{
    public int Id { get; set; }

    public int PlayerId { get; set; }

    public int Level { get; set; }

    public int Stars { get; set; }

    public int Score { get; set; }
}
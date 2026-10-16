using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathKingdom.Models;

public class Question
{
    public int Id { get; set; }

    public string Text { get; set; } = "";

    public string OptionA { get; set; } = "";

    public string OptionB { get; set; } = "";

    public string OptionC { get; set; } = "";

    public string CorrectAnswer { get; set; } = "";

    public string Topic { get; set; } = "";

    public string Difficulty { get; set; } = "";
}
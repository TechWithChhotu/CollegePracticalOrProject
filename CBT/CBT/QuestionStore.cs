using System;
using System.Collections.Generic;

public class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public char CorrectAnswer { get; set; }
    public char userInput { get; set; }

    public Question(string text, List<string> options, char correctAnswer)
    {
        Text = text;
        Options = options;
        CorrectAnswer = correctAnswer;
    }
}

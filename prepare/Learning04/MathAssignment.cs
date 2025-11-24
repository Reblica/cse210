using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string text, string textbookSection, string problems) : base(studentName, text)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection}  Problems: {_problems}";
    }
}
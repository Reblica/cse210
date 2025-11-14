using System;

public class PromptGenerator()
{
    List<string> _prompts = new List<string>()
    {
        "If I had one thing I could do over today, what would it be?", "What was the best part of my day?"
        , "Who was the most interesting person I interacted with today?", "What is something I complete today?"
    };
    public string GetRandomPrompt()
    {
        
        Random random = new Random();
        int ran = random.Next(0, 3);
        string prompt = _prompts[ran];

        return prompt;
    }
    


}
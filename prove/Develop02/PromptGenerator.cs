using System;

public class PromptGenerator()
{
    List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int ran = random.Next(1, 5);
        string prompt = _prompts[ran];

        return prompt;
    }
    


}
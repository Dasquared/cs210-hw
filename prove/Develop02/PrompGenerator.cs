using System;
using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts;
    public HashSet<string> _usedPrompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _usedPrompts = new HashSet<string>();

        _prompts.Add("What did I learn today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was I grateful for today and how can I help someone else be grateful too?");
        _prompts.Add("Who did I pray for today and why?");
        _prompts.Add("What did I do wrong today and want to apologize tomorrow to improve?");
    }

    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            return null;
        }

        Random randomGenerator = new Random();
        string randomPrompt;

        do
        {
            int index = randomGenerator.Next(0, _prompts.Count);
            randomPrompt = _prompts[index];
        } while (_usedPrompts.Contains(randomPrompt));

        _usedPrompts.Add(randomPrompt);

        return randomPrompt;
    }

    // Nueva función para guardar otra información en la entrada del diario
    public string SaveOtherInformation(string entryText, string additionalInfo)
    {
        // Concatenar la información adicional a la entrada del diario
        return $"{entryText} | Additional Info: {additionalInfo}";
    }
}

using System;

public class ReflectingActivity : Activity
{
    private List<string> _reflectionPrompts;
    private List<string> _questionsList;
    private string _prompt;
    private string _question1;
    private string _question2;
    private string _question3;
    private string _question4;
    private string _question5;
    private string _question6;
    private string _question7;
    private string _question8;
    
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown atrength and resilience. This will help you recognizw the power you have and how you can use it in other aspects of your life.";
        _prompt = "Think of a time when you stood up for someone else.";
    }
    public string GetRandomReflectionPrompt()
    {
        _reflectionPrompts = new List<string>();
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
        _reflectionPrompts.Add("Think of a story about a memorable trip you took.");
        _reflectionPrompts.Add("Think of a time when you achieved something you had worked hard for.");
        _reflectionPrompts.Add("Think of a time when you learned something important from a mistake you made.");
        _reflectionPrompts.Add("Think of a moment when you made a surprising discovery or realization.");
        Random random = new Random();
        int indexOfPrompt1 = random.Next(_reflectionPrompts.Count);
        _prompt = _reflectionPrompts[indexOfPrompt1];
        return _prompt;
    }
    private void GetRandomQuestion()
    {
        _questionsList = new List<string>();
        _questionsList.Add("Why was this experience meaningful to you?");
        _questionsList.Add("Have you ever done anything like this before?");
        _questionsList.Add("How did you get started?");
        _questionsList.Add("How did you feel when it was complete?");
        _questionsList.Add("What made this time different than other times when you were not as successful?");
        _questionsList.Add("What is your favorite thing about this experience?");
        _questionsList.Add("What could you learn from this experience that applies to other situations?");
        _questionsList.Add("What did you learn about yourself through this experience?");
        _questionsList.Add("How can you keep this experience in mind in the future?");
        Random random = new Random(); 
        int index1 = random.Next(_questionsList.Count);
        int index2;
        int index3;
        int index4;
        int index5;
        int index6;
        int index7;
        int index8;
        do  // This is the part that exceeds requirements.
        {
            index2 = random.Next(_questionsList.Count);
        } while (index1 == index2);
        do
        {
            index3 = random.Next(_questionsList.Count);
        } while (index1 == index3 || index2 == index3);
        do
        {
            index4 = random.Next(_questionsList.Count);
        } while (index1 == index4 || index2 == index4 || index3 == index4);
        do
        {
            index5 = random.Next(_questionsList.Count);
        } while (index1 == index5 || index2 == index5 || index3 == index5 || index4 == index5);
        do
        {
            index6 = random.Next(_questionsList.Count);
        } while (index1 == index6 || index2 == index6 || index3 == index6 || index4 == index6 || index5 == index6);
        do
        {
            index7 = random.Next(_questionsList.Count);
        } while (index1 == index7 || index2 == index7 || index3 == index7 || index4 == index7 || index5 == index7 || index6 == index7);
        do
        {
            index8 = random.Next(_questionsList.Count);
        } while (index1 == index8 || index2 == index8 || index3 == index8 || index4 == index8 || index5 == index8 || index6 == index8 || index7 == index8);
        _question1 = _questionsList[index1];
        _question2 = _questionsList[index2];
        _question3 = _questionsList[index3];
        _question4 = _questionsList[index4];
        _question5 = _questionsList[index5];
        _question6 = _questionsList[index6];
        _question7 = _questionsList[index7];
        _question8 = _questionsList[index8];
        
    }
    public void DisplayReflectionPrompt()
    {
        _prompt = this.GetRandomReflectionPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestion()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        this.PauseWithCountdown(5);
        Console.Clear();
        this.GetRandomQuestion();
        if (_seconds <= 15)
        {
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(_seconds);
            Console.WriteLine();
        }
        else if (_seconds <= 30)
        {
            int secondsPerQuestion = _seconds / 2;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        else if (_seconds <= 45)
        {
            int secondsPerQuestion = _seconds / 3;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question3}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        else if (_seconds <= 60)
        {
            int secondsPerQuestion = _seconds / 4;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question3}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question4}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        else if (_seconds <= 75)
        {
            int secondsPerQuestion = _seconds / 5;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question3}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question4}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question5}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        else if (_seconds <= 90)
        {
            int secondsPerQuestion = _seconds / 6;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question3}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question4}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question5}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question6}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        else if (_seconds <= 105)
        {
            int secondsPerQuestion = _seconds / 7;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question3}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question4}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question5}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question6}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question7}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        else
        {
            int secondsPerQuestion = _seconds / 8;
            Console.Write($"> {_question1}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question2}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question3}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question4}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question5}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question6}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question7}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
            Console.Write($"> {_question8}");
            this.PauseWithSpinner(secondsPerQuestion);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
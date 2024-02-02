using System;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts;
    private int _items;
    private string _listingPrompt;
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _items = 0;
        _listingPrompt = "A prompt";
    }

    public string GetListingPrompt()
    {
        _listingPrompts = new List<string>();
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");
        _listingPrompts.Add("What times have you experienced a life-changing event?");
        _listingPrompts.Add("What are the things you are grateful for?");
        _listingPrompts.Add("Who are people that you miss a lot?");
        _listingPrompts.Add("What accomplishments you feel proud of?");
        _listingPrompts.Add("What are some happy memories that you have?");
        Random random = new Random();
        int indexOfListingPrompt1 = random.Next(_listingPrompts.Count);
        _listingPrompt = _listingPrompts[indexOfListingPrompt1];
        return _listingPrompt;
    }
    public int GetItems()
    {
        return _items;
    }
    public void DisplayListingPrompt()
    {
        _listingPrompt = this.GetListingPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_listingPrompt} ---");
    }
    public void Listing()
    {
        Console.Write("You may begin in: ");
        this.PauseWithCountdown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_seconds);
        while (DateTime.Now < endTime)
        {
            _items++;
            Console.Write("> ");
            Console.ReadLine();
        }
    }
    public void DisplayItemsAmount()
    {
        if (_items == 1)
        {
            Console.WriteLine($"You listed {_items} item!");
        }
        else
        {
            Console.WriteLine($"You listed {_items} items!");
        }
        Console.WriteLine();
    }
}
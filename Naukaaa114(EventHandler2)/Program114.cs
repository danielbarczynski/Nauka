using System;

Console.WriteLine("Press A");
var key = Console.ReadLine(); 

if (key == "a")
    KeyPressed();

static void KeyPressed() 
{
    Button button = new();    
    button.ClickEvent += (sender, e) =>
    {
        e.Name = "Daniel";
        Console.WriteLine($"{sender} clicked {e.Name} {e.Age}");
    };

    button.OnClick();
}

public class Button
{
    public event EventHandler<MyArgs> ClickEvent; // without <MyArgs> it won't see a Name prop
    public void OnClick()
    {
        MyArgs myArgs = new(23);

        if (ClickEvent != null)
            ClickEvent.Invoke(this, myArgs);
    }
}

public class MyArgs : EventArgs
{
    public MyArgs(int Age)
    {
        this.Age = Age;
    }
    public string Name { get; set; } = "Ian";
    public int Age { get; set; }
}
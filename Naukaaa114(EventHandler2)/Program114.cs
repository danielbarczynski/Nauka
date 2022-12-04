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
        e.Name = "Ian";
        Console.WriteLine($"Button clicked {e.Name}");
    };

    button.OnClick();
}

public class Button
{
    public event EventHandler<MyArgs> ClickEvent; // without <MyArgs> it won't see a Name prop
    public void OnClick()
    {
        MyArgs myArgs = new();

        if (ClickEvent != null)
            ClickEvent.Invoke(this, myArgs);
    }
}

public class MyArgs : EventArgs
{
    public string Name { get; set; } = "Daniel";
}
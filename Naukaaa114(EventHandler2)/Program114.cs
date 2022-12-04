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
        Console.WriteLine("Button clicked");
    };
    
    button.OnClick();
}

public class Button
{
    public event EventHandler ClickEvent;
    public void OnClick()
    {
        ClickEvent(this, EventArgs.Empty);
    }
}
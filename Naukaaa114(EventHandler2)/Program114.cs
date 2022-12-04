using System;

Console.WriteLine("Press A");
var key = Console.ReadLine(); 

static void KeyPressed() 
{
    if (key == 'a')
        MyClass.OnClick();
}

public class MyClass
{
    public event EventHandler ClickEvent;
    public static void OnClick()
    {
        ClickEvent(this, EventArgs.Empty);
    }
}
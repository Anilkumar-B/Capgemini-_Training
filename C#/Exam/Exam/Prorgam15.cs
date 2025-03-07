using System;

public class Button
{
    // Delegate declaration
    public delegate void ClickHandler();

    // Event based on the delegate
    public event ClickHandler OnClick;

    public void Click()
    {
        // Trigger the event if subscribed
        if (OnClick != null)
        {
            OnClick();
        }
        else
        {
            Console.WriteLine("No event handlers assigned to the button.");
        }
    }

    public static void Execute()
    {
        Button button = new Button();

        // Subscribe to the event
        button.OnClick += ButtonClicked;

        // Simulate button click
        button.Click();
    }

    private static void ButtonClicked()
    {
        Console.WriteLine("Button was clicked!");
    }
}

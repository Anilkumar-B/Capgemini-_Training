using System;
using System.Collections.Generic;

namespace Exam
{
    // The INotificationObserver interface defines the method for updating observers
    public interface INotificationObserver
    {
        void Update(string message);
    }

    // The INotificationSubject interface defines the method for attaching, detaching, and notifying observers
    public interface INotificationSubject
    {
        void Attach(INotificationObserver observer);
        void Detach(INotificationObserver observer);
        void Notify();
    }

    // Concrete Subject: Notification Service
    public class NotificationService : INotificationSubject
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();
        private string _message;

        // Method to attach observers
        public void Attach(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        // Method to detach observers
        public void Detach(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        // Method to notify all observers about the new message
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_message);
            }
        }

        // Method to set a new message and notify observers
        public void SetMessage(string message)
        {
            _message = message;
            Notify(); // Notify all observers when a new message is set
        }
    }

    // Concrete Observer: Email Notifier
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    // Concrete Observer: SMS Notifier
    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}

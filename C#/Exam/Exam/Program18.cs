using System;

namespace Exam
{
    // ConfigurationManager Singleton Class
    public class ConfigurationManager
    {
        // The private static instance of ConfigurationManager
        private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        // Private constructor to prevent instance creation from outside
        private ConfigurationManager()
        {
            // Initialize default configuration settings here
            Console.WriteLine("Configuration Manager Initialized.");
        }

        // Public property to access the Singleton instance
        public static ConfigurationManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        // Method to get a configuration value (example)
        public string GetConfiguration(string key)
        {
            // Simulate getting a configuration value by key
            return $"Value for {key}";
        }

        // Method to set a configuration value (example)
        public void SetConfiguration(string key, string value)
        {
            // Simulate setting a configuration value by key
            Console.WriteLine($"Setting {key} to {value}");
        }
    }
}

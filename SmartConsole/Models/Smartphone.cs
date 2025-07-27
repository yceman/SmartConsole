using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartConsole.Models
{
    public abstract class Smartphone
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string IMEI { get; set; }
        public string Model { get; set; }
        public int Storage { get; set; } // in GB
        public int RAM { get; set; } // in GB
        public string OperatingSystem { get; set; }
        public abstract void DisplayInfo();

        public Smartphone(string brand, string name, string phoneNumber, string imei, string model, int storage, int ram, string operatingSystem)
        {
            Brand = brand;
            Name = name;
            PhoneNumber = phoneNumber;
            IMEI = imei;
            Model = model;
            Storage = storage;
            RAM = ram;
            OperatingSystem = operatingSystem;

        }
        public void Call(string number)
        {
            Console.WriteLine($"Calling {number} from {PhoneNumber}...");
        }

        public void SendMessage(string number, string message)
        {
            Console.WriteLine($"Sending message to {number}: {message}");
        }
        public void ReceiveCall(string number)
        {
            Console.WriteLine($"Receiving call from {number} on {PhoneNumber}...");
        }
        public void ReceiveMessage(string number, string message)
        {
            Console.WriteLine($"Received message from {number}: {message}");
        }
        public void BrowseInternet(string url)
        {
            Console.WriteLine($"Browsing to {url} on {Brand} {Name}...");
        }

        public void TakePhoto()
        {
            Console.WriteLine($"Taking a photo with {Brand} {Name}...");
        }

        public void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on {Brand} {Name}...");
        }

        /*public class SmartphoneDetails : Smartphone
        {
            public override void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Storage: {Storage} GB");
                Console.WriteLine($"RAM: {RAM} GB");
                Console.WriteLine($"Operating System: {OperatingSystem}");
            }
        }*/
    }
}

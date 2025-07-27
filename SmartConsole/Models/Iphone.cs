using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartConsole.Models
{
    public class Iphone : Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Name: {Name}, Phone Number: {PhoneNumber}, IMEI: {IMEI}, Model: {Model}, Storage: {Storage}GB, RAM: {RAM}GB, OS: {OperatingSystem}");
        }
        public Iphone(string brand, string name, string phoneNumber, string imei, string model, int storage, int ram, string operatingSystem) : base(brand, name, phoneNumber, imei, model, storage, ram, operatingSystem)
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

        public void FaceTime(string number)
        {
            Console.WriteLine($"Starting FaceTime call with {number} on {Brand} {Name}...");
        }
        public void UseSiri(string command)
        {
            Console.WriteLine($"Using Siri to {command} on {Brand} {Name}...");
        }
        public void UseApplePay(string amount)
        {
            Console.WriteLine($"Using Apple Pay to pay {amount} on {Brand} {Name}...");
        }
        public void UseAirDrop(string fileName)
        {
            Console.WriteLine($"Using AirDrop to send {fileName} on {Brand} {Name}...");
        }
        public void UseFindMyIphone()
        {
            Console.WriteLine($"Using Find My iPhone to locate {Brand} {Name}...");
        }
        public void UseIcloud()
        {
            Console.WriteLine($"Using iCloud to backup data on {Brand} {Name}...");
        }
        public void UseAppleMusic(string songName)
        {
            Console.WriteLine($"Playing {songName} on Apple Music on {Brand} {Name}...");
        }
        public void UseAppleMaps(string destination)
        {
            Console.WriteLine($"Navigating to {destination} using Apple Maps on {Brand} {Name}...");
        }
        public void UseAppStore(string appName)
        {
            Console.WriteLine($"Installing {appName} from the App Store on {Brand} {Name}...");
        }
        public void UseHealthApp()
        {
            Console.WriteLine($"Using Health app to track fitness on {Brand} {Name}...");
        }

        public void UseSafari(string url)
        {
            Console.WriteLine($"Browsing to {url} using Safari on {Brand} {Name}...");
        }

        public void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on {Brand} {Name}...");
        }
    }
}

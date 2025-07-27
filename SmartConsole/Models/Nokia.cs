using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartConsole.Models
{
    public class Nokia : Smartphone
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Name: {Name}, Phone Number: {PhoneNumber}, IMEI: {IMEI}, Model: {Model}, Storage: {Storage}GB, RAM: {RAM}GB, OS: {OperatingSystem}");
        }
        // Nokia specific methods can be added here
        public Nokia(string brand, string name, string phoneNumber, string imei, string model, int storage, int ram, string operatingSystem) 
            : base(brand, name, phoneNumber, imei, model, storage, ram, operatingSystem)
        {
            /*Brand = brand;
            Name = name;
            PhoneNumber = phoneNumber;
            IMEI = imei;
            Model = model;
            Storage = storage;
            RAM = ram;
            OperatingSystem = operatingSystem;*/
        }
        public void UseNokiaMaps(string destination)
        {
            Console.WriteLine($"Navigating to {destination} using Nokia Maps on {Brand} {Name}...");
        }
        public void UseNokiaMusic(string songName)
        {
            Console.WriteLine($"Playing {songName} on Nokia Music on {Brand} {Name}...");
        }
        public void UseNokiaStore(string appName)
        {
            Console.WriteLine($"Installing {appName} from Nokia Store on {Brand} {Name}...");
        }
        public void UseNokiaAssistant(string command)
        {
            Console.WriteLine($"Using Nokia Assistant to {command} on {Brand} {Name}...");
        }
        public void UseNokiaCamera()
        {
            Console.WriteLine($"Taking a photo with Nokia Camera on {Brand} {Name}...");
        }
        public void UseNokiaPay(string amount)
        {
            Console.WriteLine($"Using Nokia Pay to pay {amount} on {Brand} {Name}...");
        }
        public void UseNokiaFindMyPhone()
        {
            Console.WriteLine($"Using Find My Phone to locate {Brand} {Name}...");
        }
        public void UseNokiaCloud()
        {
            Console.WriteLine($"Using Nokia Cloud to backup data on {Brand} {Name}...");
        }
        public void UseNokiaMapsOffline(string destination)
        {
            Console.WriteLine($"Navigating to {destination} using Nokia Maps Offline on {Brand} {Name}...");
        }
        public void UseNokiaHealth(string healthData)
        {
            Console.WriteLine($"Tracking health data: {healthData} on {Brand} {Name}...");
        }
        public void UseNokiaGallery()
        {
            Console.WriteLine($"Viewing photos in Nokia Gallery on {Brand} {Name}...");
        }
        public void UseNokiaSettings()
        {
            Console.WriteLine($"Accessing settings on {Brand} {Name}...");
        }
        public void UseNokiaCalendar(string eventDetails)
        {
            Console.WriteLine($"Adding event to calendar: {eventDetails} on {Brand} {Name}...");
        }
        public void UseNokiaContacts(string contactName)
        {
            Console.WriteLine($"Accessing contact: {contactName} on {Brand} {Name}...");
        }
        public void UseNokiaWeather(string location)
        {
            Console.WriteLine($"Checking weather for {location} on {Brand} {Name}...");
        }
        public void UseNokiaNews(string newsCategory)
        {
            Console.WriteLine($"Reading {newsCategory} news on {Brand} {Name}...");
        }
        public void UseNokiaSocialMedia(string platform)
        {
            Console.WriteLine($"Accessing {platform} on {Brand} {Name}...");
        }
        public void UseNokiaEmail(string emailAddress)
        {
            Console.WriteLine($"Sending email to {emailAddress} from {Brand} {Name}...");
        }
        public void UseNokiaBrowser(string url)
        {
            Console.WriteLine($"Browsing to {url} on {Brand} {Name}...");
        }
        public void UseNokiaVoiceAssistant(string command)
        {
            Console.WriteLine($"Using Nokia Voice Assistant to {command} on {Brand} {Name}...");
        }
        public void UseNokiaFileManager(string fileName)
        {
            Console.WriteLine($"Managing file: {fileName} on {Brand} {Name}...");
        }
        public void UseNokiaBluetooth(string deviceName)
        {
            Console.WriteLine($"Connecting to {deviceName} via Bluetooth on {Brand} {Name}...");
        }
        public void UseNokiaWiFi(string networkName)
        {
            Console.WriteLine($"Connecting to {networkName} WiFi on {Brand} {Name}...");
        }
        public void UseNokiaHotspot(string networkName)
        {
            Console.WriteLine($"Creating hotspot with {networkName} on {Brand} {Name}...");
        }
        public void UseNokiaVPN(string vpnName)
        {
            Console.WriteLine($"Connecting to {vpnName} VPN on {Brand} {Name}...");
        }
        public void UseNokiaNotifications()
        {
            Console.WriteLine($"Checking notifications on {Brand} {Name}...");
        }
        public void UseNokiaSecurity(string securityFeature)
        {
            Console.WriteLine($"Using {securityFeature} security feature on {Brand} {Name}...");
        }
        public void UseNokiaAccessibility(string feature)
        {
            Console.WriteLine($"Using {feature} accessibility feature on {Brand} {Name}...");
        }

        public void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} on {Brand} {Name}...");
        }
    }   
}

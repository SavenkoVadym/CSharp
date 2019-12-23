using System;
namespace Lab_11._1
{
    class Patient
    {
        public Patient()
        {
            MRTsuccessful = false;
            KTsuccessful = false;
            XRaySuccessful = false;
            LORsuccessful = false;
            UZIsuccessful = false;
            RevmoSuccessful = false;
        }
        public bool MRTsuccessful { get; set; }
        public bool KTsuccessful { get; set; }
        public bool XRaySuccessful { get; set; }
        public bool LORsuccessful { get; set; }
        public bool UZIsuccessful { get; set; }
        public bool RevmoSuccessful { get; set; }
        public void DisplayStatus()
        {
            Console.WriteLine("Patient status:");
            Console.WriteLine($"MRT = { MRTsuccessful}\nKT = {KTsuccessful}\nXray = {XRaySuccessful}\nLOR = {LORsuccessful}\nUZI = {UZIsuccessful}\nRevmo = {RevmoSuccessful}\n");
        }
    }
}
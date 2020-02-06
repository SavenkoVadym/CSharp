using System;
namespace Lab_11._1
{
    class Program
    {
        public delegate void myDelegate(Patient patient);
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Hospital hospital = new Hospital();
            myDelegate delegate1 = hospital.MRT;
            myDelegate delegate2 = hospital.KT;
            myDelegate delegate3 = hospital.Xray;
            myDelegate delegate4 = hospital.LOR;
            myDelegate delegate5 = hospital.UZI;
            myDelegate delegate6 = hospital.Revmo;
            myDelegate delegateAll = delegate1 + delegate5 + delegate3;
            delegate1(patient);
            delegateAll(patient);
            patient.DisplayStatus();
            Console.ReadKey();
        }
    }
}

namespace Lab_11._1
{
    class Hospital
    {
        public Hospital() { }
        public void MRT(Patient patient)
        {
            patient.MRTsuccessful = true;
        }
        public void KT(Patient patient)
        {
            patient.KTsuccessful = true;
        }
        public void Xray(Patient patient)
        {
            patient.XRaySuccessful = true;
        }
        public void LOR(Patient patient)
        {
            patient.LORsuccessful = true;
        }
        public void UZI(Patient patient)
        {
            patient.UZIsuccessful = true;
        }
        public void Revmo(Patient patient)
        {
            patient.RevmoSuccessful = true;
        }
    }
}
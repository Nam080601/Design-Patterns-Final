namespace Design_Patterns_Final.src.Provider
{
    class OTPProvider
    {
        string otp = "";
        private static OTPProvider instance;
        public static OTPProvider Instance
        {
            get { if (instance == null) instance = new OTPProvider(); return instance; }
            private set { instance = value; }
        }
        private OTPProvider() { }
        public string GetOTP()
        {
            return otp;
        }
        public void SetOTP(string otp)
        {
            this.otp = otp;
        }
        public void RemoveOTP()
        {
            otp = "";
        }
    }
}

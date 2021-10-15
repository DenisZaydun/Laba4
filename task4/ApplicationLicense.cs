namespace task4
{
    class ApplicationLicense
    {
        public enum LicenseTypes
        {
            Common = 0,
            Trial,
            Pro
        }

        private string TrialKey = "VK7JG-NPHTM-C97JM-9MPGT-3V66T";
        private string ProKey = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";

        public LicenseTypes License
        {
            get;
            set;
        }

        public LicenseTypes DefineLicense(string key)
        {
            if (key == TrialKey)
            {
                AllowTrial();
            }
            else if (key == ProKey)
            {
                AllowPro();
            }
            else
            {
                AllowCommon();               
            }
            
            return License;
        }

        public void AllowCommon()
        {
            License = LicenseTypes.Common;   
        }

        public void AllowTrial()
        {
            License = LicenseTypes.Trial;
        }
        public void AllowPro()
        {
            License = LicenseTypes.Pro;
        }
    }
}

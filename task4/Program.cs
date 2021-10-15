
using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            ApplicationLicense license = new ApplicationLicense();

            Console.Write("Введіть ключ ліцензії: ");
            license.DefineLicense(Console.ReadLine());

            if (license.License == ApplicationLicense.LicenseTypes.Pro)
            {
                Pro pro = new Pro();
                
            }
            else if (license.License == ApplicationLicense.LicenseTypes.Trial)
            {
                Trial trial = new Trial();
            }
            else if(license.License == ApplicationLicense.LicenseTypes.Common)
            {
                Common common = new Common();
            }
        }
    }
}

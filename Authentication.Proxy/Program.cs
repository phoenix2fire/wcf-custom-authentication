using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Authentication.Proxy.ServiceReference1;
using System.ServiceModel.Security;

namespace Authentication.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client proxy = new Service1Client();
            proxy.ClientCredentials.UserName.UserName = "abc";
            proxy.ClientCredentials.UserName.Password = "abc";
            proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            proxy.Open();
            Console.WriteLine(proxy.GetData(1213));
            Console.ReadKey();
        }
    }
}

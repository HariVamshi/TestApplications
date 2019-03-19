using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace csNetworkTest
{
  class Program
  {
    static void Main(string[] args)
    {
      WebRequest request = WebRequest.Create(" http://mnit.ac.in/");
      request.Credentials = CredentialCache.DefaultCredentials;
      WebResponse response = request.GetResponse();

      Console.WriteLine(((HttpWebResponse)response).StatusDescription);
      Stream datastream = response.GetResponseStream();
      StreamReader reader = new StreamReader(datastream);
      string responseFromServer = reader.ReadToEnd();
      Console.WriteLine(responseFromServer);
      reader.Close();
      response.Close();
      Console.ReadKey();
    }
  }
}

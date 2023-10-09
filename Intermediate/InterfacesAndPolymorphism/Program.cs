using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{    
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailINotificationChannel());
            encoder.RegisterNotificationChannel(new SMSINotificationChannel());
            encoder.Encode(new Video());
        }
    }
}

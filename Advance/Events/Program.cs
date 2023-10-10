using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Events
    // A mechanism for communication between objects.
    // Used in building loosely coupled applications.
    // Helps extending applications.

    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder videoEncoder = new VideoEncoder();
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;            // Add events in Event Handler
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            Video video = new Video { Title = "Video1" };
            videoEncoder.Encode(video);
        }
    }
}

using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {        
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of video objects

                throw new Exception("Opps some low level YouTube error.");
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos form YouTube.", ex);
            }

            return new List<Video>();
        }
    }
}

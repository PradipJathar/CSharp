using System;
using System.IO;

namespace InterfacesAndExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }


        public void LogError(string message)
        {
            Log(message, MessageTypes.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, MessageTypes.Error);
        }

        public void Log(string message, string messageType)
        {
            if (!Directory.Exists(Path.GetDirectoryName(_path)))
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(_path));
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error creating directory: {ex.Message}");
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {   
                streamWriter.WriteLine($"{messageType}: {message}");
                streamWriter.Dispose();
            };
        }
        
    }
}

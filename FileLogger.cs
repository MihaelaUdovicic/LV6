using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            //implementation missing!
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filePath, true))
            {
                file.WriteLine(type + ": " + DateTime.Now);
                file.WriteLine(new string('=', message.Length));
                file.WriteLine(message);
                file.WriteLine(new string('=', message.Length) + "\n");
            }
        }
    }
}

using System;

namespace Online_Radio_Database.ExceptionClasses
{
    public class InvalidSongException :Exception
    {
        private string exceptionMessage = "Invalid song.";

        protected virtual string ExceptionMessage
        {
            set
            {
                this.exceptionMessage = value;
            }
        }

        public override string Message => exceptionMessage;
    }
}

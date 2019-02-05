namespace Online_Radio_Database.ExceptionClasses
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}

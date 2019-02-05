namespace Online_Radio_Database.ExceptionClasses
{
    public class InvalidSongMinutesException : InvalidSongException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}

namespace Online_Radio_Database.ExceptionClasses
{
    public class InvalidSongSecondsException : InvalidSongException
    {
        public override string Message => "Song seconds should be between 0 and 59.";
    }
}

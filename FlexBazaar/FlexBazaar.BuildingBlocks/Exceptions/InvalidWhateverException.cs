namespace FlexBazaar.BuildingBlocks.Exceptions;

public class InvalidWhateverException : Exception
{
    private const string _messages = "Invalid whatever string.";

    public InvalidWhateverException() : base(_messages) { }

    public static void Throw(string whatever)
    {
        
        if (!whatever.Equals("whatever"))
        {
            throw new InvalidWhateverException();
        }
    }
}
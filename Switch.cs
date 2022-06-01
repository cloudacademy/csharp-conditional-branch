public static class Rating
{
    public static string ToString(int rating)
    {
        string text = string.Empty;

        switch (rating)
        {                        
            case < 3 when (rating > 0):
                text = "Not good";
                break;                
            case 3:
                text = "Average";
                break;
            case <= 5 when (rating > 0):
                text = "Good";
                break;                  
            default:
                text = "Rating out of range";
                break;
        }

        return text;
    }
}








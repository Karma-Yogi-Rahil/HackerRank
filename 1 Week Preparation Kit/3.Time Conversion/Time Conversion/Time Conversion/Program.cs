using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string time = "12:40:22AM";
        Console.WriteLine(MilitaryTimeConversion(time));
    }

    /// <summary>
    /// Converts 12hour time to military time.(12:40:22AM" -> 00:40:22).
    /// </summary>
    /// <param name="givenTime">Time in 12hr format.</param>
    /// <returns>Time in 24hr format.</returns>
    public static string MilitaryTimeConversion(string givenTime)
    {
        // Splits the srting in array.
        string[] array = givenTime.Split(":");

        // Checks PM in the string.
        int result = Regex.Matches(array[2], "PM").Count;
        
        int hour = int.Parse(array[0]);
        string militaryTime = string.Empty;
        
        // PM is present in the string.
        if (result == 1)
        {
            // hour is not 12
            if (hour != 12)
            {
                hour += 12;
            }

            militaryTime = string.Format("{0}:{1}:{2}",
                                      hour.ToString("00"),        // 0
                                      array[1],                   // 1
                                      array[2].Substring(0, 2));  // 2

            return militaryTime;

        }

        // hour is equal to 12
        if (hour == 12)
        {
            hour = 0;
        }

        militaryTime = String.Format("{0}:{1}:{2}",
                                     hour.ToString("00"),       // 0
                                    array[1],                   // 1
                                    array[2].Substring(0, 2));  // 2

        return militaryTime;

    }
}

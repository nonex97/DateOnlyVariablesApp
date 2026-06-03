/*
DateTime today = DateTime.Now;


DateOnly birthday = DateOnly.Parse("20/04/1969");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));


Console.WriteLine($"Today full format: {today}"); // Displays the full date and time
Console.WriteLine($"Today just date: {today.Date}"); // Shows that .Date also includes the time component set to midnight
Console.WriteLine($"Birthday full format: {birthday}"); // Shows just the date without time, as DateOnly does not include time information since we don't need a time zone for a date only
*/

// Ask the user their name
Console.Write("Please type your name: ");
string name = Console.ReadLine();

// Ask the user for their birth year and store it in a variable
Console.Write("Please type the year you were born in (YYYY): ");
int birthYear = int.Parse(Console.ReadLine());

// Calculate the user's age
int today = DateTime.Now.Year;
int age = today - birthYear;

string? year = null;

if (age == 1)
{
    year = "year";
} else if (age >= 2 || age <= 0)
{
    year = "years";
}

Console.WriteLine($"Hi {name}! Today you are {age} {year} old.");
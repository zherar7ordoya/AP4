public static void Main()
	{
		Console.WriteLine("Hello World");
		
		DateTime birthdate = new DateTime(1972, 12, 13);
		
		// Save today's date.
		var today = DateTime.Today;
		
		// Calculate the age.
		var age = today.Year - birthdate.Year;
		
		// Go back to the year in which the person was born in case of a leap year
		if (birthdate.Date > today.AddYears(-age)) age--;
		
		Console.WriteLine("Edad: " +  age);
	}
}
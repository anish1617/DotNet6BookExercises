using static System.Console;

WriteLine("Earliest date/time value is: {0}",
		arg0: DateTime.MinValue);

WriteLine("UNIX epoch date/time value is: {0}",
		arg0: DateTime.UnixEpoch);

WriteLine("Date/time value Now is: {0}",
		arg0: DateTime.Now);

WriteLine("Date/time value Today is: {0}",
		arg0: DateTime.Today);

DateTime christmas = new(year:2023, month:12, day:25);

WriteLine("Christmas: {0}",
		arg0: christmas); // default format
WriteLine("Christmas: {0:dddd, dd MMMM yyyy}",
		arg0: christmas); // custom format

WriteLine("Christmas is in month {0} of the year",
		arg0:christmas.Month);

WriteLine("Christmas is day {0} of the year",
		arg0: christmas.DayOfYear);

WriteLine("Christmas {0} is on a {1}.",
		arg0: christmas.Year,
		arg1: christmas.DayOfWeek);

DateTime beforeXmas = christmas.Subtract(TimeSpan.FromDays(12));
DateTime afterXmas = christmas.AddDays(12);

WriteLine("12 Days before chrismas is: {0}",
		arg0: beforeXmas);
WriteLine("12 days after christmas is: {0}",
		arg0: afterXmas);

TimeSpan untilXmas = christmas - DateTime.Now;

WriteLine($"There are {untilXmas.Days} days and {untilXmas.Hours} hours until christmas.");

WriteLine($"There are {untilXmas.TotalHours:N0} hours until christmas");



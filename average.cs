//Average of the marks introduced by the user

using System;

public class Average
{

	public static void Main()
	{
		double notesSum = 0, numericalMark, counterMarks = 0, average;
		string mark;

		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();

		while (mark != "end")
		{
			numericalMark = Convert.ToDouble(mark);

			counterMarks++;

			notesSum += numericalMark;

			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if (counterMarks != 0)
		{
			average = notesSum / counterMarks;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}

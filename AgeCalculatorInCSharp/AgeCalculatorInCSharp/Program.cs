using System;

namespace AgeCalculatorInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Type your date of birth (MM/DD/YYYY): ");
			var dueDate = Convert.ToDateTime(Console.ReadLine());
			var today = DateTime.Now.Date;
			Console.WriteLine("Your have passed: " + CalculateAge(dueDate, today));

			Console.ReadKey();
		}

		private static string CalculateAge(DateTime dueDate, DateTime today)
		{
			int y, m, d;
			string result = "";
			int days = Int32.Parse((today - dueDate).TotalDays.ToString());

			y = days / 365;
			m = (days % 365) / 30;
			d = (days % 365) % 30;

			if (m >= 12 && d < 30)
			{
				y++;
				m -= 12;
			}
			else if (d >= 30 && m < 12)
			{
				m++;
				d -= 30;
			}

			if (y > 0 && m > 0 && d > 0)
			{
				result = String.Format("{0} year {1} month {2} day", y, m, d);
			}
			else if (y > 0 && m > 0 && d == 0)
			{
				if (y > 1 && m == 1)
				{
					result = String.Format("{0} years {1} month", y, m);
				}
				else if (y == 1 && m > 1)
				{
					result = String.Format("{0} year {1} months", y, m);
				}
				else
				{
					result = String.Format("{0} year {1} month", y, m);
				}
			}
			else if (y > 0 && d > 0 && m == 0)
			{
				if (y > 1 && d == 1)
				{
					result = String.Format("{0} years {1} day", y, d);
				}
				else if (y == 1 && d > 1)
				{
					result = String.Format("{0} year {1} days", y, d);
				}
				else
				{
					result = String.Format("{0} year {1} day", y, d);
				}
			}
			else if (m > 0 && d > 0 && y == 0)
			{
				if (m > 1 && d == 1)
				{
					result = String.Format("{0} months {1} day", m, d);
				}
				else if (m == 1 && d > 1)
				{
					result = String.Format("{0} month {1} days", m, d);
				}
				else
				{
					result = String.Format("{0} month {1} day", m, d);
				}
			}
			else if (y > 0 && m == 0 && d == 0)
			{
				if (y > 1)
				{
					result = String.Format("{0} years", y);
				}
				else
				{
					result = String.Format("{0} year", y);
				}
			}
			else if (y == 0 && m > 0 && d == 0)
			{
				if (m > 1)
				{
					result = String.Format("{0} months", m);
				}
				else
				{
					result = String.Format("{0} month", m);
				}
			}
			else if (y == 0 && m == 0 && d > 0)
			{
				if (d > 1)
				{
					result = String.Format("{0} days", d);
				}
				else
				{
					result = String.Format("{0} day", d);
				}
			}
			else if (y == 0 && m == 0 && d == 0)
			{
				result = "0 day";
			}
			else
			{
				result = "Please input correct date";
			}

			return result;
		}
	}
}

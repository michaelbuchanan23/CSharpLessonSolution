using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson {
	class Program {

		//can use this struct when we need a type with both name and number
		//also note that structs must go outside of the main method
		//we declared "gamer" ken below
		struct gamer {
			public string name;
			public int favnbr;
		}
		

		static void Main(string[] args) {

			int a = 23 * 37;
			int b = a - 41;
			int c = b / 7;
			string aStr = a.ToString(); //changes the int value of a to string and puts it in a variable called aStr
			Console.WriteLine(c);

			//the pro way to do the above equation is as shown below here according to Greg -- also variable names should have meanings
			int w = 23;
			int x = 37;
			int y = 41;
			int z = 7;
			int ans = ((w * x) - y) / z;
			Console.WriteLine(ans);

			string name = "Mike";
			int days = 6;
			string daysStr = days.ToString();
			string msg = "My name is " + name + ". I've been in bootcamp for " + daysStr + " days.";
			Console.WriteLine(msg);

			//calculate days I've been alive
			int YearsOld = 37;
			int CurrentMonth = 29;
			int DaysPerYear = 365;
			int LeapYearDays = 8;

			int January = 31;
			int February = 28;
			int March = 31;
			int April = 30;
			int May = 31;
			int June = 30;
			int July = 31;
			int August = 31;
			int September = 30;
			int October = 31;
			int November = 30;
			int December = 31;

			int DaysFirstYear = 20 + May + June + July + August + September + October + November + December;
			int DaysThisYear = January + February + March + April + CurrentMonth;
			
			int DaysAlive = ((YearsOld - 1) * DaysPerYear) + DaysFirstYear + DaysThisYear + LeapYearDays;

			Console.WriteLine(DaysAlive);

			//Easier way to do the equation to find how many days old you are using the Days method
			DateTime EndDate = new DateTime(2018, 5, 29);
			DateTime StartDate = new DateTime(1981, 4, 11);
			int DOld = (EndDate - StartDate).Days;
			Console.WriteLine(DOld);

			//Bowling game
			int[] frames = new int[10];
			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;
			int game = frames.Sum(f => f);
			Console.WriteLine(game);
			
			//frames.Length tells us there are 10 items in the array
			/* can also calculate score with a counter
			int score = 0;
			for (int idx = 0; idx < frames.Length; idx++)
			{
				score += frames[idx];
			}
			Console.WriteLine(score);
			*/

			//foreach is made to loop through an array
			int score = 0;
			foreach (int frame in frames) {
				score += frame;
			}
			Console.WriteLine(score);

			//Array string with classmates
			string[] names = {
				"Greg", "Michael", "Dan", "Anna",
				"Marcus", "Foster", "Jermaine", "Mitchell",
				"Jonathan", "Larry", "William"
			};
			//say hi to each person above
			foreach (string aname in names) {
				Console.WriteLine("Hi " + aname);
			}

			//name, city/state, email and print it out using the foreach loop
			string[] myinfo = {
				"Mike Buchanan", "Taylor Mill, KY", "michaelbuchanan23@gmail.com"
			};
			foreach (string info in myinfo) {
				Console.WriteLine(info);
			}

			//these variables are created from the "gamer" struct above
			gamer ken;
			ken.name = "Ken";
			ken.favnbr = 10;
			Console.WriteLine(ken.name + " " + ken.favnbr);
			gamer nick;
			nick.name = "Nick";
			nick.favnbr = 7;
			//create an array of gamers
			gamer[] gamers = { ken, nick };
			//foreach the array of gamers
			foreach(gamer gmr in gamers) {
				Console.WriteLine("Gamer {0}'s favorite number is {1}", gmr.name, gmr.favnbr);
			}
		}
	}
}

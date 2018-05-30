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

			//DAYS ALIVE CODE
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
			//END DAYS ALIVE CODE

			//BOWLING GAME RELATED CODE IS SHOWN BELOW -- there are differing ways to do this and I left all code we went over in class
			//tracks scores in a bowling game and defines the array as having an index of 10
			int[] frames = new int[10];

			//assigns scores to the frames array
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

			//there are 3 different ways to calculate the bowling score as shown below

			//calculates bowling score and outputs
			int game = frames.Sum(f => f);
			Console.WriteLine(game);

			//can also calculate score with a counter as shown below -- frames.Length gives 10 items in the array
			int score = 0; //this variable accumulates the total score below
			for (int idx = 0; idx < frames.Length; idx++) {
				score += frames[idx];
			}
			Console.WriteLine(score);

			//the below foreach accumulates the bowling score in frames above
			//foreach is made to loop through an array
			//foreach ([type], [variable] in [collection/array])
			int score2 = 0;
			foreach (int frame in frames) {

				score2 += frame;
			}
			Console.WriteLine(score);
			//END BOWLING GAME CODE


			//creates an array string with classmates
			string[] names = {
				"Greg", "Michael", "Dan", "Anna",
				"Marcus", "Foster", "Jermaine", "Mitchell",
				"Jonathan", "Larry", "William"
			};

			//say hi to each person above in the array
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


			//these variables are created from the "gamer" struct at the top of this program.cs
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
			foreach (gamer gmr in gamers) {
				Console.WriteLine("Gamer {0}'s favorite number is {1}", gmr.name, gmr.favnbr);
			}


			//using Console.ReadLine() to obtain a string response and then print said response
			Console.Write("Enter a number from 1 to 10: ");
			string response = Console.ReadLine();
			Console.WriteLine(response);


			//working with if statments and comparisons
			Console.Write("Enter 100, 200, or 300: ");
			string ans1 = Console.ReadLine();
			int x1 = int.Parse(ans1); //converts string to an integer
			string color = "red";
			if (x1 == 100) {
				Console.WriteLine("x1 is equal to 100");
				if (color == "red") {
					Console.WriteLine("Color is red");
				} else {
					if (color == "yellow") {
						Console.WriteLine("Color is yellow");
					} else {
						if (color == "green") {
							Console.WriteLine("Color is green");
						} else {
							Console.WriteLine("Color is something else");
						}
					}
				}
			} else {
				if (x1 == 200) {
					Console.WriteLine("x1 is  equal to 200");
				} else {
					if (x1 == 300) {
						Console.WriteLine("x1 is equal to 300");
					} else {
						Console.WriteLine("x1 is not 100, 200, or 300");
					}
				}
			}
			//END WORKING WITH IF STATEMENTS AND COMPARISON CODE 


			//WHILE LOOPS
			int idx2 = 0;
			while (idx2 < 50) {
				if (idx2 % 2 == 0) {//only returns the even numbers
					Console.WriteLine("The index {0} is even", idx2); //replace {0} with what comes after the comma
				}
				if (idx2 % 3 == 0) {//only returns numbers divisible by 3
					Console.WriteLine("The index {0} is div by 3", idx2); //replace {0} with what comes after the comma
				}
				if (idx2 % 7 == 0) {//only returns numbers divisible by 7
					Console.WriteLine("The index {0} is div by 7", idx2); //replace {0} with what comes after the comma
				}
				idx2++; //equal to idx2 = idx2 + 1 OR idx2 += 1
			}
			//END WHILE LOOPS
			

			//FOR LOOPS
			for (int idx3 = 0; idx3 < 50; idx3++) {
				if (idx3 % 2 == 0) {//only returns the even numbers
					Console.WriteLine("The index {0} is even", idx3); //replace {0} with what comes after the comma
				}
				if (idx3 % 3 == 0) {//only returns numbers divisible by 3
					Console.WriteLine("The index {0} is div by 3", idx3); //replace {0} with what comes after the comma
				}
				if (idx3 % 7 == 0) {//only returns numbers divisible by 7
					Console.WriteLine("The index {0} is div by 7", idx3); //replace {0} with what comes after the comma
				}
			}
			//END FOR LOOPS

			//incrementing math 
			int y2 = 0; //y2 = 0
			int a2 = y2++; //a2 = 0 and y2 = 1 because y2 increments after the assignment
			int b2 = ++y2; //b2 = 2 and y2 = 2 and a2 = 0 because y2 increments before the assignment
		}
	}
}

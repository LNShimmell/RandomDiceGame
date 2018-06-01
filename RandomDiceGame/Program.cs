using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RandomDiceGame
{
	class Program
	{
		 Random roll = new Random();// Random class is called to create a new random object roll


		 int RNG()//Method 
		{
			return roll.Next(1, 7);//adjusting these attributes changes the type of die example 1,5 would be a four sided die, 1,13 would be a twelve and so on
		}

		 void Game(){
			int die = RNG();//the die score from each throw is then stored into 'die'
			long Crolls = 0;// counts the number of throws the game has completed
			int score = 0; // keeps track of the current score
			int MaxScore = 0;// keeps track of the highest score while the game is running.
			long games = 1;// keeps track of how many games the program has executed
			
		

			while (score < 1000){//Change this value to make the game quit sooner. The likely hood of reaching 1000 without a super computer is almost zero
				if(die != 1)
				{
					score += die;
					Crolls += 1;

				}
				if(die == 1)// if the program rolls  1
				{
					score *= 0;//score will become zero
					Crolls += 1;
					games += 1;
				}
				die = RNG();
				if (score > MaxScore)
				{
					MaxScore = score;
					Console.WriteLine("High Score: {0}\nRolls: {1}\nGames: {2}\n------------------------------", MaxScore, string.Format("{0:n0}", Crolls), string.Format("{0:n0}", games));
					
				}
				if (Crolls%100000000==0)// will only display the next line
				{
					
					Console.WriteLine("High Score: {0}\nRolls: {1}\nGames: {2}\n------------------------------", MaxScore, string.Format("{0:n0}", Crolls), string.Format("{0:n0}", games));
					
				}


				
			}
			Console.WriteLine("Your score is {0}, it took you {1} rolls", score, Crolls);
		}

		void run()
		{

			Game();
		}

		static void Main(string[] args)
		{
			(new Program()).run();//  Starts up Game method
		}
	}
}

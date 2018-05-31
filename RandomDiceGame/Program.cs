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
		 Random roll = new Random();


		 int RNG()
		{
			return roll.Next(1, 7);
		}

		 void Game(){
			int die = RNG();
			long Crolls = 0;
			int score = 0;
			int MaxScore = 0;
			long games = 1;
			
		

			while (score < 1000){
				if(die != 1)
				{
					score += die;
					Crolls += 1;

				}
				if(die == 1)
				{
					score *= 0;
					Crolls += 1;
					games += 1;
				}
				die = RNG();
				if (score > MaxScore)
				{
					MaxScore = score;
					Console.WriteLine("High Score: {0}\nRolls: {1}\nGames: {2}\n------------------------------", MaxScore, string.Format("{0:n0}", Crolls), string.Format("{0:n0}", games));
					
				}
				if (Crolls%100000000==0)
				{
					
					score += die;
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
			(new Program()).run();
		}
	}
}

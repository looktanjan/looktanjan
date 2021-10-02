using System;
using System.Collections.Generic;
namespace HangMan
{
	public class HangManGame 
	{
		public static void Main()
		{  
			Homepage();
			work();	
		}
		
		public static void work()
		{
			string secretword = "badminton";
			List<string> letterGuessed = new List<string>();
			int score = 0;
			Isletter(secretword,letterGuessed);
			while (score < 6)
			{
				string input = Console.ReadLine();
				if (letterGuessed.Contains(input))
				{
					Console.Clear();
					Console.WriteLine("Play Game Hangman ");
					Console.WriteLine("");
					Console.WriteLine("--------------------------");
					Console.WriteLine(" ");
					Console.WriteLine("You Entered [{0}] already",input);
					Console.WriteLine(" ");
					Console.WriteLine("Try a Different Word");
					Console.WriteLine(" ");
					GetAlphabet(input);
					continue;
				}
				letterGuessed.Add(input);
				if (IsWord(secretword,letterGuessed))
				{
					Console.Clear();
					Console.WriteLine("Play Game Hangman ");
					Console.WriteLine("");
					Console.WriteLine("--------------------------");
					Console.WriteLine(" ");
					Console.WriteLine(secretword);
					Console.WriteLine("");
					Console.WriteLine("Your Win !!!");
					break;
				}
				else if (secretword.Contains(input))
				{
					Console.Clear();
					Console.WriteLine("Play Game Hangman ");
					Console.WriteLine("");
					Console.WriteLine("--------------------------");
					Console.WriteLine(" ");
					Console.WriteLine("Nice Entry");
					Console.WriteLine("");
					string letters = Isletter(secretword,letterGuessed);
					Console.WriteLine(letters);
					Console.WriteLine("");
					Console.WriteLine("Input letter alphabet: ");
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Play Game Hangman ");
					Console.WriteLine("");
					Console.WriteLine("--------------------------");
					Console.WriteLine(" ");
					Console.WriteLine("letter Not in My Word");
					Console.WriteLine("");
					score+= 1;
					Console.WriteLine("Incorrect Score : {0} ",score);
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine("Input letter alphabet: ");
				}
				Console.WriteLine();
				if (score == 6)
				{
					Console.Clear();
					Console.WriteLine("Play Game Hangman ");
					Console.WriteLine("");
					Console.WriteLine("--------------------------");
					Console.WriteLine(" ");
					Console.WriteLine("game Over :( ");
					Console.WriteLine("");
					Console.WriteLine("Word is  {0} ",secretword);
					break;
				}
			}
		}
		
		public static void Homepage()
		{
			Console.WriteLine("Welcome to Hangman Game ");
			Console.WriteLine("");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("1. Play Game");
			Console.WriteLine("");
			Console.WriteLine("2. Exit");
			Console.WriteLine("");
			Console.WriteLine("Please Select Menu :");
			Console.WriteLine("");
			int menu = int.Parse(Console.ReadLine());
			switch (menu)
			{
				case 1:
					{
						selectone();
						break;
					}
				case 2:
					{
						Console.WriteLine("End Game");
						break;
					}
			}
		}
		
		public static void selectone()
		{
			Console.Clear();
			Console.WriteLine("Play Game Hangman");
			Console.WriteLine("");
			Console.WriteLine("--------------------------");
			Console.WriteLine("");
			Console.WriteLine("Incorrect Score : 0");
			Console.WriteLine("");
			Console.WriteLine("--------------------------");
			Console.WriteLine("");
			Console.WriteLine("input letter alphabet : ");
			Console.WriteLine("");
		}
		public static bool IsWord (string secreword, List<string> letterGuessed)
		{
			bool word = false;
			for (int i=0; i<secreword.Length; i++)
			{
				string c = Convert.ToString(secreword[i]);
				if (letterGuessed.Contains(c))
				{
					word = true;
				}
				else
				{
					return word = false;
				}
			}
			return word;
		}
		
		 public static string Isletter(string secretword,List<string> letterGuessed)
		 {
			 string correctletters = " ";
			 for (int i =0; i<secretword.Length; i++)
			 {
				 string c = Convert.ToString(secretword[i]);
				 if (letterGuessed.Contains(c))
				 {
					 correctletters += c;
				 }
				 else
				 {
					 correctletters += "_ ";
				 }
			 }
			 return correctletters;
		 }
		public static void GetAlphabet (string letters)
		{
			List<string> alphabet = new List<string>();
			for (int i =1; i <= 26 ; i++)
			{
				char alpha = Convert.ToChar(i+96);
				alphabet.Add(Convert.ToString(alpha));
			}
			int num=49;
			Console.WriteLine("Letters Left are : ");
			Console.WriteLine("");
			for (int i = 0; i<num; i++)
			{
				if (letters.Contains(letters))
				{
					alphabet.Remove(letters);
					num -= 1;
				}
				Console.Write("["+alphabet[i]+"]");
			}
			Console.WriteLine();
		}
	}
}

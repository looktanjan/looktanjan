using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		homepage();
		Console.Clear();
		homepage();
	}
	public static void homepage()
	{
		Console.WriteLine("Welcome to Digital Library");
		Console.WriteLine("");
		Console.WriteLine("--------------------------------");
		Console.WriteLine("");
		Console.WriteLine("1.Login");
		Console.WriteLine("");
		Console.WriteLine("2.Register");
		Console.WriteLine("");
		Console.WriteLine("Select Menu:");
		int selectmenu = Convert.ToInt32(Console.ReadLine());
		switch (selectmenu)
		{
			case 1:
				{
					Console.Clear();
					login();
					break;
				}
			case 2 :
				{
					Console.Clear();
					register();
					break;
				}
		}
	}
	
	public static void login()
	{
		Console.WriteLine("Login Screen");
		Console.WriteLine("");
		Console.WriteLine("----------------");
		
	}
	public static void register()
	{
		Console.WriteLine("Register new Person");
		Console.WriteLine("");
		Console.WriteLine("-------------------------");
		Console.WriteLine("");
		name();
		pass();
		type();
	}
	
	public static void name()
	{
		Console.Write("Input Name :");
		string inputname = Convert.ToString(Console.ReadLine());
		//Console.WriteLine("{0}",inputname);
	}
	public static void pass()
	{
		Console.Write("Input Password :");
		string inputpass = Convert.ToString(Console.ReadLine());
	}
	public static void stdid()
	{
		Console.Write("Student ID :");
		string inputstdid = Convert.ToString(Console.ReadLine());
	}
	public static void empid()
	{
		Console.Write("Employee ID :");
		string inputempid = Convert.ToString(Console.ReadLine());
	}
	
	public static void type()
	{
		Console.Write("Input User Type 1 = Student, 2 = Employee :");
		int type = Convert.ToInt32(Console.ReadLine());
		switch (type)
		{
			case 1:
				{
					stdid();
					break;
				}
			case 2:
				{
					empid();
					break;
				}
		}
	}
	
}

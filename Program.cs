/*
 * Created by SharpDevelop.
 * User: Mathieu
 * Date: 29/11/2022
 * Time: 16:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GenerationMdp
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Random rnd = new Random();
//			int codeASCII = rnd.Next(97, 122);
//			
//			Console.WriteLine(codeASCII);
//			
//			char lettre = (char)codeASCII;
//			Console.WriteLine(lettre);
			
			String mdp = "";
			for (int i = 0 ; i < 14 ; i++)
			{
				int codeASCII = rnd.Next(97, 122);
				char lettre = (char)codeASCII;
				
				mdp = mdp + lettre;
			}
			
			Console.WriteLine("le mot de passe est : " + mdp);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
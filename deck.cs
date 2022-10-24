using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deckofcards8d11
{
	internal class deck
	{
		public class CardOfDecks
		{

			public static void main(String[] args)
			{

				String[] cardType = { "Clubs", "Diamonds", "Hearts", "Spades" };
				String[] cardNumbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
				String[] cardsArray = new String[52];
				int start = 0, end = 12, j1 = 0;
				for (int i = 0; i < 4; i++)
				{
					for (int j = start; j <= end; j++)
					{
						cardsArray[j] = cardType[i] + " " + cardNumbers[j1];
						j1++;
					}
					j1 = 0;
					start = end + 1;
					end += 13;
				}

				OOPsUtility.shuffleCardsDeck(cardsArray);
				Console.WriteLine("**************************************");


				int j2 = 0;
				for (int i = 0; i < 4; i++)
				{
					Console.WriteLine("For Player " + i + ": \n");
					for (int j = 0; j < 9; j++)
					{

						Console.WriteLine(cardsArray[j2] + "-->");
						j2++;
					}
					Console.WriteLine();
				}
			}
		}
	}

    internal class OOPsUtility
    {
        internal static void shuffleCardsDeck(string[] cardsArray)
        {
            throw new NotImplementedException();
        }
    }
}

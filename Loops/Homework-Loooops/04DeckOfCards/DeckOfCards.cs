﻿using System;

class DeckOfCards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A", };
        string[] boi = { "♣ ", "♦ ", "♥ ", "♠ " };

        for (int i = 0; i < 15; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                switch (i)
                {
                    case 0: 
                    case 1: 
                    case 2: 
                    case 3: 
                    case 4: 
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    Console.Write(cards[i] + boi[k]);
                        break;
                }

            }
            Console.WriteLine();
        }
    }
}      
                   
                    
           


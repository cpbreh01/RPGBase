using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    public static class RPGUtils
    {
        //2-25-15 - CB Added Methods to deal with in Game Dice Rolls

        /// <summary>
        /// Helper method to return values of Dice rolls in the form of a list of integers.
        /// </summary>
        /// <param name="_NumOfDice">Number of dice to be rolled</param>
        /// <param name="_NumOfSides">Number of sides on rolled dice</param>
        /// <returns>List of integer values representing results of rolled dice.</returns>
        public static List<int> RollDice(int _NumOfDice, int _NumOfSides)
        {
            List<int> _RollResults = new List<int>();
            Random _RandomNumberGenerator = new Random();

            _NumOfSides+= 1; //Random.next() normally doesn't return the upper bound of it's value so we add 1 to it so that it can return max number. 
            for (int i = 0; i < _NumOfDice; i++)
            {
                _RollResults.Add(_RandomNumberGenerator.Next(0,_NumOfSides));
            }

            return _RollResults;
        }

        /// <summary>
        /// Helper method to return result of a percentage dice roll
        /// </summary>
        /// <returns>integer value between 0 and 100</returns>
        public static int ReturnPercentageDiceRoll()
        {
            Random _RandomNumberGenerator = new Random();
            //Return a number x where -1 > x > 101 (i.e. x cannot equal -1 or 101)
            return _RandomNumberGenerator.Next(-1, 101);
        }


        /// <summary>
        /// Helper method to return result of Dice rolls.
        /// </summary>
        /// <param name="_NumOfDice">Number of dice to roll</param>
        /// <param name="_NumOfSides">Number of sides on dice</param>
        /// <param name="_ValueToAddToResult">Value to add to result of rolls.</param>
        /// <returns>An integer value representing result of dice rolls</returns>
        public static int RollMultipleDiceAndReturnResult(int _NumOfDice, int _NumOfSides, int _ValueToAddToResult)
        {
            return (RollDice(_NumOfDice, _NumOfSides).Sum() + _ValueToAddToResult);
        }

        /// <summary>
        /// Helper method to return result of Dice rolls.
        /// </summary>
        /// <param name="_NumOfDice">Number of dice to roll</param>
        /// <param name="_NumOfSides">Number of sides on dice</param>
        /// <returns>An integer value representing result of dice rolls</returns>
        public static int RollMultipleDiceAndReturnResult(int _NumOfDice, int _NumOfSides)
        {
            return (RollDice(_NumOfDice, _NumOfSides).Sum());
        }

        /// <summary>
        /// Helper method to return result of Dice rolls without the lowest roll included.
        /// </summary>
        /// <param name="_NumOfDice">Number of dice to roll</param>
        /// <param name="_NumOfSides">Number of sides on dice</param>
        /// <returns>An integer value representing result of dice rolls</returns>
        public static int RollMultipleDiceAndReturnResultIgnoreLowestRoll(int _NumOfDice, int _NumOfSides)
        {
            List<int> _DiceRollValues = RollDice(_NumOfDice, _NumOfSides);
            _DiceRollValues.Sort(); //Sort values ascending
            _DiceRollValues.RemoveAt(0); //Remove lowest value
            return _DiceRollValues.Sum();
        }
        
    
    }
}

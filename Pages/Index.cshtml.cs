﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601DiceRolls2020.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string>? Dice { get; set; }

        public IndexModel()
        {
            //instantiate the List
            Dice = new List<string>();
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Dice = new List<string>();

            var list = DiceRoll();

            Dice.AddRange(list);
        }

        private List<string> DiceRoll()
        {

            //Define a random generator that uses milliseconds as the seed 
            Random myrandom = new(DateTime.Now.Millisecond);

            //Create and set the values of the 2 dice 
            int Dice1;
            int Dice2;

            do  //roll the dice while ....
            {
                //pass the random number to two variables 
                Dice1 = myrandom.Next(1, 7);
                Dice2 = myrandom.Next(1, 7);

                //Add them to the list
                Dice.Add(Dice1 + " " + Dice2);

                //while Dice 1 doesn't equal Dice 2
            } while (Dice1 != Dice2);



            return Dice;


        }

    }
}
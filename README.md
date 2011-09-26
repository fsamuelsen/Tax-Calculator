Tax Calculator
==============

Two solutions for the code challenge presented by Ayende
--------------------------------------------------------

The 1st solution (TaxCalculator1)
--------------------------------
I went right ahead and hardcoded all the tax levels inside the class . The logic is just a bunch of if/else and a switch.
The problem with this solution is that is would require a rewrite if the number of levels or any amount or percentage changed.

The 2nd solution (TaxCalculator2)
---------------------------------
I then realized that it was a good idea to inject the tax levels and percentages into the calculator. I created a class TaxLevel to hold info for each Tax Level.
The CalulateTax method loops over each Tax Level and calculates tax for each level, and the tax for any remaining amount in the last level.

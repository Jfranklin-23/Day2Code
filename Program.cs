
    Random rnd = new Random();

    int die1 = rnd.Next(1, 7);
    int die2 = rnd.Next(1, 7);
    int die3 = rnd.Next(1, 7);

    int score = die1 + die2 + die3;

    int bonuspoints = 0;

    if (die1 == die2 || die1 == die3 || die2 == die3)

    {bonuspoints +=2;}

    if (die1 == die2 && die1 == die3)

    {bonuspoints +=6;}

    score += bonuspoints;

    Console.WriteLine($"Dice roll: {die1} + {die2} + {die3} = {score}");

    if(score >= 15)
    {Console.WriteLine("Congratulations, Panalo ka!");}

    else
    {Console.WriteLine("Pasensya na, Talo ka");}
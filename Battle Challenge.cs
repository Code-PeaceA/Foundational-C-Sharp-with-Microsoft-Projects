/*
A hero and a monster start with the same health score. During the hero's turn, they'll generate a random value which will be subtracted from the monster's health. If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle will resume.
*/

// initialise characters' health points
int heroHealthPoints = 10;
int monsterHealthPoints = 10;

Random random = new Random();

do
{
    int attackPoints = random.Next(1, 11);
    monsterHealthPoints -= attackPoints;
    Console.WriteLine($"Monster was damaged and lost {attackPoints} health and now has {monsterHealthPoints} health.");

    if (monsterHealthPoints <= 0) continue;

    attackPoints = random.Next(1, 11);
    heroHealthPoints -= attackPoints;
    Console.WriteLine($"Hero was damaged and lost {attackPoints} health and now has {heroHealthPoints} health.");



} while (heroHealthPoints > 0 && monsterHealthPoints > 0);

Console.WriteLine(heroHealthPoints > monsterHealthPoints ? "Hero wins!" : "Monster wins!");

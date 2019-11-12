using HeroFight.Core.Contracts;
using HeroFight.Entities.Heroes;
using HeroFight.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroFight.Core
{
    public class ArenaController : IArenaController
    {
        List<Hero> heroes = new List<Hero>();
        public string CreateHero(List<string> args)
        {
            string heroType = args[0];
            string heroName = args[1];
            string result = $"Hero with name: {heroName} already exists!";
            if(heroes.FirstOrDefault(h=> h.Name==heroName)==null)
            {
                Hero hero = new Hero(heroName);
                switch (heroType)
                {
                    case "Assassin":
                        hero = new Assassin(heroName);
                        break;
                    case "Priest":
                        hero = new Priest(heroName);
                        break;
                    case "Warrior":
                        hero = new Warrior(heroName);
                        break;
                    default:
                        result = "Invalid type hero: InvalidType.";
                        break;
                }
                if(result!= "Invalid type hero: InvalidType.")
                {
                    heroes.Add(hero);
                    result = $"{heroType}: {heroName} joined the Arena!";
                }
            }            
            return result;
        }

        public string CreateWeapon(List<string> args)
        {
            string heroName = args[0];
            string weaponType = args[1];
            string weaponName = args[2];
            int strength = int.Parse(args[3]);
            int agility = int.Parse(args[4]);
            int intelligence = int.Parse(args[5]);

            string result = $"Successfully armed hero {heroName} with weapon {weaponType}!";
            Hero hero = heroes.FirstOrDefault(h => h.Name == heroName);
            if (hero != null)
            {
                switch (weaponType)
                {
                    case "Bow":
                        hero.Weapon = new Bow(weaponName, strength, agility, intelligence);
                        break;
                    case "MagicWand":
                        hero.Weapon = new MagicWand(weaponName, strength, agility, intelligence);
                        break;
                    case "Sword":
                        hero.Weapon = new Sword(weaponName, strength, agility, intelligence);
                        break;
                    default:
                        result = $"Invalid type weapon: {weaponType}.";
                        break;
                    
                }
                /*if(result!= $"Invalid type weapon: {weaponType}.")
                {
                    hero = ChangeWeapon(hero);
                }*/
            }
            else
            {
                result = $"Hero with name: {heroName} does not exist!";
            }
            return result;
        }


        public string Fight(List<string> args)
        {
            string firstHeroName = args[0];
            string secondHeroName = args[1];
            Hero firstHero = heroes.FirstOrDefault(h => h.Name == firstHeroName);
            Hero secondHero = heroes.FirstOrDefault(h => h.Name == secondHeroName);
            string result;
            if(firstHero != null)
            {
                if (secondHero != null)
                {
                    if(firstHero.Power == secondHero.Power)
                    {
                        firstHero.Experience += 15;
                        secondHero.Experience += 15;

                        result = $"No winner in battle between {firstHeroName} " +
                            $"and {secondHeroName}!";
                    }
                    else
                    {
                        string winnerName = "";
                        double differencePower = 0;
                        if (firstHero.Power> secondHero.Power)
                        {
                            winnerName = firstHeroName;
                            firstHero.Experience += 30;
                        }
                        else
                        {
                            winnerName = secondHeroName;
                            secondHero.Experience += 30;
                        }
                        differencePower = Math.Abs(firstHero.Power - secondHero.Power);
                        result = $"Winner in the battle between {firstHeroName}" +
                            $" and {secondHeroName} " +
                         $"is {winnerName} with {differencePower:f2}.";
                    }   
                    

                }
                else
                {
                    result = $"Hero with name: {secondHeroName} does not exist!";
                }
            }
            else
            {
                result = $"Hero with name: {firstHeroName} does not exist!";
            }

            return result;
        }

        public string HeroInfo(List<string> args)
        {
            string heroName = args[0];
            Hero hero = heroes.FirstOrDefault(h => h.Name == heroName);
            string result = $"Hero with name: {heroName} does not exist!";
            if (hero != null)
            {
                result = hero.ToString();
            }
            return result;
        }

        public string CloseArena()
        {
            string resul;
            var sortedHeroes = heroes
                .OrderByDescending(h => h.Level)
                .ThenByDescending(h => h.Power)
                .ThenBy(h => h.Name);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Heroes: {heroes.Count}");
            foreach (var hero in sortedHeroes)
            {
                sb.AppendLine(hero.ToString());
            }
            resul = sb.ToString().Trim();

            return resul;
        }

    }
}

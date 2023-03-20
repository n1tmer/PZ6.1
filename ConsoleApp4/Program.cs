using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    internal class Program
    {
        class Monsters
        {
            static void Main(string[] args)
            { PrintBigMonsters(Monster); PrintMonsterHP(monsterHP); }
            public string Name { get; set; }
            public Monsters(string name, int hp, int dmg)
            {
                Name = name;
                HP = hp;
                DMG = dmg;
            }

            static List<Monsters> Monster = new List<Monsters>
    {
        new Monsters("Hilichurl",40,15),
        new Monsters("Abyss Mag",100,40),
        new Monsters("Treasure Hunter",50,30)
    }; 
           
            
            public int HP { get; set; }
            public int DMG { get; set; }
            static void PrintBigMonsters(List<Monsters> monsters)
            {
                var BigMonsters = monsters.Where(monster => monster.HP >= 60 && monster.DMG >= 30).Select(monster => monster.Name).ToList();
                BigMonsters.ForEach(Console.WriteLine);
            }
            static List<Monsters> monsterHP = new List<Monsters>();
            static void PrintMonsterHP(List<Monsters> monsters)
            {
                var MonsterHP = from m in Monster  where m.HP > 0 orderby m select m;  
            }
            
            





        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientationClassExercises.Inheritance;

namespace ObjectOrientationClassExercises.Interfaces
{
    internal class InterfacesSample
    {
        private List<GameCharacter> dungeon;

        public InterfacesSample()
        {
            dungeon = new List<GameCharacter>();
        }
        public void Battle()
        {
            foreach(IDamagable damagable in dungeon)
            {
                damagable.Attack();
            }

        }

        public void Loot()
        {
            foreach(ILootable lootable in dungeon)
            {
                lootable.Steal();
            }
        }



        public void LootFromDragon()
        {
            foreach (ILootable lootable in dungeon)
            {
                if (lootable is Dragon)
                {
                    lootable.Steal();
                }
            }
        }
        public void Run( )
        {

        //List<GameCharacter> dungeon = new List<GameCharacter>();


            GameCharacter character = new Wizard(100, 50, "Wizard", "Oz", Gender.NotSpecified, 98 , Race.White, false);
            dungeon.Add(character);

            character = new Goblin(10, 1000, "Tommy", "Gobby", Gender.NotSpecified, 150, Race.Indian, false);
            dungeon.Add(character);

            character = new Dragon(200, 5000, "Daemon", "Bob", Gender.NotSpecified, 1252, Race.African, false);
            dungeon.Add(character);



            Battle();

            Loot();
        }
    }
}

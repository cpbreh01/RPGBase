using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{

    //TODO: We may want to make RACE and CLASS into custom class objects. That or because CLASS and RACE are determined after 
    //doing the ability rolls.
    //Another option may be to create a custom method to implement a character class and race. (AddCLASS add AddRACE) This would of course add Attribute modifiers
    //- CB2_25_15

    //RACES: Human, Dwarf, Elf, Gnome, Halfling, Half-Elf, Half-Orc, Monster(Maybe)
    //Class: Barbarian, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rouge, Sorcerer, Wizard. (We should add Tourist and Samurai as an homage to Nethack)


    public class Character
    {
        private string name;
        private int age;                            //Added 2-25-15
        private string gender;                      //Added 2-25-15
        private string race;
        private int hitPoints;                      //Class Base + Constitution modifier.
        private int initative;                      //TDexterity Modifier (+ any feat bonus)
        private int speed;
        private Alignment characterAlignment;

        //TODO: Create Level Class
            //Apparently every 4th level allows you to add 1 point to any attribute.
        //TODO: Figure out how to track ATTACK BONUS - this is determined by Class Base + Strength modifer

        public Attribute Strength;
        public Attribute Dexterity;
        public Attribute Constitution;
        public Attribute Intelligence;
        public Attribute Charisma;
        public Attribute Wisdom;

        public ArmorClass CharacterArmorClass;
        public Save Fortitude;                      //Class base + Constitution Modifier
        public Save Reflex;                         //Class base + Dexterity Modifier
        public Save Will;                           //Class base + Wisdom Modifier

        List<Skill> Skills = new List<Skill>();

        //TODO: Create FEAT class - CB2_25_15


        #region Properties

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Race
            {
                get { return race; }
            }
            public int HitPoints
            {
                get { return hitPoints; }
                set { hitPoints = value; }
            }
            public int Initative
            {
                get { return initative; }
                set { initative = value; }
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public Alignment CharacterAlignment
            {
                get { return characterAlignment; }
                set { characterAlignment = value; }
            }

        #endregion
    }

    public enum AttributeType { Int = "Intelligence", Dex = "Dexterity", Con = "Constitution", Cha = "Charisma", Wis = "Wisdom", Str = "Strength" };

    public class MiscModifer
    {
        string ModifierName;

        //Base Attributes
        private int constitutionMod;
        private int dexterityMod;
        private int charismaMod;
        private int strengthMod;
        private int wisdomMod;
        private int intelligenceMod;

    }

    public enum Alignment {LawfulGood,NeutralGood,ChaoticGood,LawfulNeutral,TrueNeutral,ChaoticNeutral,LawfulEvil,NeutralEvil,ChaoticEvil}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    public class Character
    {
        private string name;
        private string race;
        private int hitPoints;
        private int initative;
        private int speed;
        private Alignment characterAlignment;

        public Attribute CharacterAttributes;

        public ArmorClass CharacterArmorClass;
        public Save Fortitude;
        public Save Reflex;
        public Save Will;



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

    enum AttributeType { Int = "Intelligence", Dex = "Dexterity", Con = "Constitution", Cha = "Charisma", Wis = "Wisdom", Str = "Strength" };

    public class Attribute
    {
        //Base Attributes
        private int constitution;
        private int dexterity;
        private int charisma;
        private int strength;
        private int wisdom;
        private int intelligence;

        //Other Properties
        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
    }

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

    enum Alignment {LawfulGood,NeutralGood,ChaoticGood,LawfulNeutral,TrueNeutral,ChaoticNeutral,LawfulEvil,NeutralEvil,ChaoticEvil}
}
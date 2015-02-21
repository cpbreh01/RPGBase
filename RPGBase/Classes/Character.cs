using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    public class Character
    {
        //Note int is an unsigned

        private string name;
        private string race;
        private int hitPoints;
        private int initative;
        private int speed;
        private ArmorClass characterArmorClass;
        public Attribute characterAttributes;
        private Alignment characterAlignment;

        //public Character(string _Name, string _Race, string _BaseHp, int _Initative, int  )
        //{

        //}

        //To do: Determine which properties in this list need to be readonly. (i.e. only set in object creation or through methods.)
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
            public Alignment CharacterAlignment
            {
                get { return characterAlignment; }
                set { characterAlignment = value; }
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
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

            internal ArmorClass CharacterArmorClass
            {
                get { return characterArmorClass; }
                set { characterArmorClass = value; }
            }

    #endregion

    }

    public class Attribute
    {
        //Base Attributes
        private int constitution;
        private int dexterity;
        private int charisma;
        private int strength;
        private int wisdom;
        private int intellegence;

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
        public int Intellegence
        {
            get { return intellegence; }
            set { intellegence = value; }
        }

        public void GenerateModifiers()
        {

        }
    }


    enum Alignment {LawfulGood,NeutralGood,ChaoticGood,LawfulNeutral,TrueNeutral,ChaoticNeutral,LawfulEvil,NeutralEvil,ChaoticEvil}

    

    class Skills
    {
        string SkillName;
    }
}
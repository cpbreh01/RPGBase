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

        //TODO: Create Level Class

        public Attribute Strength;
        public Attribute Dexterity;
        public Attribute Constitution;
        public Attribute Intelligence;
        public Attribute Charisma;
        public Attribute Wisdom;

        public ArmorClass CharacterArmorClass;
        public Save Fortitude;
        public Save Reflex;
        public Save Will;

        List<Skill> Skills = new List<Skill>();




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
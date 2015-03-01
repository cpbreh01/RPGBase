using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{

    //RACES: Human, Dwarf, Elf, Gnome, Halfling, Half-Elf, Half-Orc
    //Class: Barbarian, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rouge, Sorcerer, Wizard


    public class Character
    {
        private string name;
        private int age;                            //CB - 2-25-15 - Age depending on Race affects certain Attributes. (Ex a human at the age of 30 will get -1 strength, con, and +1 Wisdom etc.)
        private string gender;                      //CB - 2-25-15 - This is the Gender of the Character
        private string race;                        //Race determines modifiers on rolls for attributes.
        private Alignment characterAlignment;
        public List<Languages> characterLanguagesSpoken;    //CB - 3/1/15 - These are the languages the character speaks this is determined initially by race and intelligence attribute..

        public Attributes CharacterAttributes; //CB - 3-1-15 - Consolidated Attributes and armor class into one class so that it would be easier to manage modifiers.
        public List<Skill> Skills;

        //CB - 2-25-15 - TODO: Figure out how to manager level ups/downs
            //Every 4th level allows you to add 1 point to any attribute.
            //Every level results in your rolling a "Hit die" to determine how many hit points you gain.
            //Level up xp requirements are defined by class.
        //CB - 2-25-15 - TODO: Create FEAT class

        private int baseHitPoints;                          //Hit Points = Class Base + Constitution modifier.
        private int currentHitPoints;
        private int baseAttack;                             //Base Attack = Class Base + Strength modifier
        private int baseFortitudeSave;                      //Fortitude = Class base + Constitution Modifier
        private int baseReflexSave;                         //Reflex = Class base + Dexterity Modifier
        private int baseWillSave;                           //Will = Class base + Wisdom Modifier
        private int movementSpeed;                          //Speed = Racial Speed + ArmorPenalty/Bonus

        /// <summary>
        /// Hit Points = Class Base + Constitution modifer
        /// </summary>
        public int MaxHitPoints
        {
            get
            {
                return baseHitPoints + CharacterAttributes.CalcConstitutionModifer;
            }
        }
        /// <summary>
        /// Initiative = DexterityModifer + Any Feat Bonus
        /// </summary>
        public int Initative
        {
            get
            {
                return CharacterAttributes.CalcDexterityModifer;    //ToDo Find a way to add in Feat Bonuses here?
            }
        }
        /// <summary>
        /// Base Attack = Class Base + Strength modifier
        /// </summary>
        public int BaseAttack
        {
            get
            {
                return baseAttack + CharacterAttributes.CalcStrengthModifer;  
            }
        }
        /// <summary>
        /// Fortitude = Class base + Constitution Modifier
        /// </summary>
        public int Fortitude
        {
            get
            {
                return baseFortitudeSave + CharacterAttributes.CalcConstitutionModifer; 
            }
        }
        /// <summary>
        /// Reflex = Class base + Dexterity Modifier
        /// </summary>
        public int Reflex
        {
            get
            {
                return baseReflexSave + CharacterAttributes.CalcDexterityModifer; 
            }
        }
        /// <summary>
        /// Will = Class base + Wisdom Modifier
        /// </summary>
        public int Will
        {
            get
            {
                return baseWillSave + CharacterAttributes.CalcWisdomModifer; 
            }
        }
        /// <summary>
        /// Speed = Racial Speed + ArmorPenalty/Bonus
        /// </summary>
        public int Speed
        {
            get
            {
                return movementSpeed + CharacterAttributes.CalcSpeedModifer; 
            }
        }

        /// <summary>
        /// This is the Characters Name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// This is the Characters Race. A race confers certain bonuses which are used to initially set a characters Attributes and skills
        /// </summary>
        public string Race
        {
            get { return race; }
        }
        /// <summary>
        /// This is the Characters Alignment. I.e. how they act.
        /// </summary>
        public Alignment CharacterAlignment
        {
            get { return characterAlignment; }
            set { characterAlignment = value; }
        }
        /// <summary>
        /// This is the characters current number of hit points.
        /// CB - 3-1-15
        /// </summary>
        public int CurrentHitPoints
        {
            get
            {
                return currentHitPoints;
            }
            set
            {
                if (value > MaxHitPoints)
                {
                    currentHitPoints = MaxHitPoints;
                }
                else
                {
                    currentHitPoints = value;
                }

            }
        }

    }


    //TODO: by combining Attributes into one class we are trying to consolidate Modifiers so we don't have to manage them across multiple objects.
    public class Attributes
    {
        public Attribute Strength;
        public Attribute Dexterity;
        public Attribute Constitution;
        public Attribute Intelligence;
        public Attribute Charisma;
        public Attribute Wisdom;
        public ArmorClass CharacterArmorClass;


        public int CalArmorClass
        {
            get
            {
                return CharacterArmorClass.generateAC(CalcDexterityModifer);
            }
        }
        public int CalFlatFootedArmorClass
        {
            get
            {
                return CharacterArmorClass.generateFlatFootedAC();
            }
        }
        public int CalTouchArmorClass
        {
            get
            {
                return CharacterArmorClass.generateTouchAC(CalcDexterityModifer);
            }
        }
        public int CalcStrengthModifer
        {
            get
            {
                return Strength.getAttributeModifier();
            }
        }
        public int CalcDexterityModifer
        {
            get
            {
                return Dexterity.getAttributeModifier();
            }
        }
        public int CalcConstitutionModifer
        {
            get
            {
                return Constitution.getAttributeModifier();
            }
        }
        public int CalcIntelligenceModifer
        {
            get
            {
                return Intelligence.getAttributeModifier();
            }
        }
        public int CalcCharismaModifer
        {
            get
            {
                return Charisma.getAttributeModifier();
            }
        }
        public int CalcWisdomModifer
        {
            get
            {
                return Wisdom.getAttributeModifier();
            }
        }
        public int CalcSpeedModifer
        {
            get
            {
                return CharacterArmorClass.generateSpeedPenaltyOrBonus(); //CB - 3-1-15 - Do we need to add in whether character is overburdened
            }
        }
    }


    //TODO: try to combine modifiers into one class so that they are easier to manage.

    public enum AttributeType { Int = "Intelligence", Dex = "Dexterity", Con = "Constitution", Cha = "Charisma", Wis = "Wisdom", Str = "Strength" };
   
    public enum ArmorModTypes { NotArmor, ArmorBonus, ShieldBonus, SizeModifier, NaturalArmor, DeflectionModifier, Micellaneous }
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

    /// <summary>
    /// Object that holds details of a language.
    /// </summary>
    public class Languages
    {
        string LanguageName;
    }
    public enum Alignment {LawfulGood,NeutralGood,ChaoticGood,LawfulNeutral,TrueNeutral,ChaoticNeutral,LawfulEvil,NeutralEvil,ChaoticEvil}
}
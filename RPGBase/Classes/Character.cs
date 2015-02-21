using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    class Character
    {
        string name;
        string race;
        int hitPoints;
        int initative;
        int speed;
        ArmorClass CharacterArmorClass;
        
        //Base Attributes
        int constitution;
        int dexterity;
        int charisma;
        int strength;
        int wisdom;
        int intellegence;

        Alignment CharacterAlignment;


    }

    enum Alignment {LawfulGood,NeutralGood,ChaoticGood,LawfulNeutral,TrueNeutral,ChaoticNeutral,LawfulEvil,NeutralEvil,ChaoticEvil}

    class Attack
    {
        int AttackModifier;
        int Damage;
        //To Do add effects
    }
    

    class Skills
    {
        string SkillName;
    }

    class ArmorClass
    {

    }
}
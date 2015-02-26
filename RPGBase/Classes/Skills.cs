using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{

    //ToDo implement a way to use an untrained skill (aka: Ability Check)
    //When you do this you compare the characters related ability
    //Some skills cannot be used untrained. We may want to add a Boolean value to indicate this.

    public class Skill
    {
        public string SkillName;
        public AttributeType KeyAbility;
        public int Rank;

        public int CalculateSkillModifer(int AttributeModifer, int MiscellaneousMod)
        {
            return AttributeModifer + Rank + MiscellaneousMod;
        }

        public Skill(string _Name, AttributeType _KeyAbility, int _Rank)
        {
            SkillName = _Name;
            KeyAbility = _KeyAbility;
            Rank = _Rank;
        }

    }
}

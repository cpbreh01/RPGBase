using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
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

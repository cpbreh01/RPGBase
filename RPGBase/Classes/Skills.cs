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

        public int CalculateSkillModifer(int AttributeModifer)
        {
            return AttributeModifer + Rank + 
        }

    }
}

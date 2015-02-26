using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    //You armor class is how hard your character is to hit.

    public enum ArmorModTypes { ArmorBonus, ShieldBonus, DexModifier, SizeModifier, NaturalArmor, DeflectionModifier, Micellaneous }


    public class ArmorClass
    {
        const int baseArmor = 10;
        List<ArmorModifiers> ACMods = new List<ArmorModifiers>();

        public int generateAC()
        {
            return baseArmor + ACMods.Sum(r => r.value);
        }

        public int generateFlatFootedAC()
        {
            return baseArmor + ACMods.Where(r => r.type != ArmorModTypes.DexModifier).Sum(r => r.value);
        }

        public int generateTouchAC()
        {
            return baseArmor + ACMods.Where(r => r.type != ArmorModTypes.ArmorBonus).Sum(r => r.value);
        }
    }

    public class ArmorModifiers{
        public ArmorModTypes type; //include Dex, Armor,
        public string typeName;
        public int    value;
    }

}

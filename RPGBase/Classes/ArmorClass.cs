using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    //You armor class is how hard your character is to hit.

    //CB - 3-1-15 Moved this enum to character page where I am trying to Define all modifiers. Added ArmorModType NotArmor so that we that I could combine all mods.
    //public enum ArmorModTypes { ArmorBonus, ShieldBonus, SizeModifier, NaturalArmor, DeflectionModifier, Micellaneous }


    public class ArmorClass
    {
        const int baseArmor = 10;
        List<ArmorModifiers> ACMods = new List<ArmorModifiers>();

        public int generateAC(int DexModifier)
        {
            return baseArmor + ACMods.Where(r => r.type != ArmorModTypes.NotArmor).Sum(r => r.value) + DexModifier;
        }

        public int generateFlatFootedAC()
        {
            return baseArmor + ACMods.Where(r => r.type != ArmorModTypes.NotArmor).Sum(r => r.value);
        }

        public int generateTouchAC(int DexModifier)
        {
            return baseArmor + ACMods.Where(r => r.type != ArmorModTypes.ArmorBonus && r.type != ArmorModTypes.NotArmor).Sum(r => r.value) + DexModifier;
        }

        //CB - 3-1-15 - TODO: Return value for speed bonus or penalty. Heavy armor will make a character move more slowly.
        public int generateSpeedPenaltyOrBonus()
        {
            return 0;
        }
    }

    public class ArmorModifiers{
        public ArmorModTypes type; //include Dex, Armor,
        public string typeName;
        public int    value;
    }

}

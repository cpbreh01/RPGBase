using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    enum ThrowModifiersClassification {Base, AbilityModifier, MagicModifier, MiscModifier, TemporaryModifer};
    enum ThrowModiferType {Fortitude, Reflex, Will };

    class Save
    {
        public ThrowModiferType Type;
        public List<SaveModifier> ModifierList;

        public int generateSave()
        {
            return ModifierList.Sum(r => r.SavModValue);
        }

        public void AddSaveModifier(SaveModifier Modifer)
        {
            if (Modifer.SavModType != Type)
            {
                throw new Exception("Incorrect modifier type");
            }

            ModifierList.Add(Modifer);
        }
    }

    class SaveModifier
    {
        public ThrowModiferType SavModType;
        public ThrowModifiersClassification SavModClassification;
        public string SavModName;
        public int SavModValue;

        public SaveModifier(ThrowModiferType _ModType, ThrowModifiersClassification _ModClass, string _ModName, int _ModValue)
        {
            SavModType = _ModType;
            SavModClassification = _ModClass;
            SavModName = _ModName;
            SavModValue = _ModValue;
        }

    }
}

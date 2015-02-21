using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGBase.Classes
{
    class Attribute
    {
        public string AttributeName;
        public AttributeType AttributeType;
        public int BaseAttributeScore;
        public List<AttributeScoreModifier> AttributeScoreModifiers = new List<AttributeScoreModifier>();

        public int getAttributeScore()
        {
            return BaseAttributeScore + AttributeScoreModifiers.Sum(r => r.ModifierValue);
        }

        public int getAttributeModifier(){
            return (Int32)(getAttributeScore() / 2);
        }

        public Attribute(string _AttributeName, AttributeType _AttributeType, int _BaseAttributeScore)
        {
            AttributeName = _AttributeName;
            AttributeType = _AttributeType;
            BaseAttributeScore = _BaseAttributeScore;
        }

        public void AddModifier(AttributeScoreModifier _Mod)
        {
            AttributeScoreModifiers.Add(_Mod);
        }

        public void RemoveModifier(string _ModifierName)
        {
            AttributeScoreModifiers.RemoveAll(r => r.ModifierName == _ModifierName);
        }
    }

    class AttributeScoreModifier
    {
        public string ModifierName;
        public int ModifierValue;
        public AttributeType AttributeType;

        public AttributeScoreModifier(string _ModifierName, int _ModifierValue, AttributeType _AttributeType)
        {
            ModifierName = _ModifierName;
            ModifierValue = _ModifierValue;
            AttributeType = _AttributeType;
        }
    }
}

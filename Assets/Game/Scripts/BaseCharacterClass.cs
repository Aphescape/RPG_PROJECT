using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    public BaseCharacterClass(String charJob)
    {
        switch(charJob) {
            case "barbarian":
                CharacterClassName = "Barbarian";
                CharacterClassDescription = @"
                    Barbarians are all about getting angry and dealing damage. They have a ton of hit points, 
                    resistance to damage, and Rage gives a wonderful bonus to damage. Barbarians don’t get much 
                    in the way of skills, so generally they’re stuck as combat monsters, but they function 
                    equally well as a Defender and a Striker, and certain character options can even expand them 
                    into a limited Support role.";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "fighter":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "paladin":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "rogue":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "ranger":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "druid":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "wizard":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "mage":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "bard":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "cleric":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "monk":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "sorcerer":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            case "warlock":
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
            default:
                CharacterClassName = "";
                CharacterClassDescription = @"";
                str = 1;
                dex = 1;
                con = 1;
                wis = 1;
                inte = 1;
                chari = 1;
                break;
        }
    }

    public String characterClassName;
    public String characterClassDescription;
    
    //stats
    public int str, dex, con, wis, inte, chari;

    public String CharacterClassName {
        get { return characterClassName; }
        set { characterClassName = value;}
    }

    public String CharacterClassDescription {
        get { return characterClassDescription; }
        set { characterClassDescription = value;}
    }

    public int Strenght {
        get { return str; }
        set { str = value; }
    }
    public int Dexterity {
        get { return dex; }
        set { dex = value; }
    }
    public int Constitution {
        get { return con; }
        set { con = value; }
    }
    public int Wisdom {
        get { return wis; }
        set { wis = value; }
    }
    public int Intelligence {
        get { return inte; }
        set { inte = value; }
    }
    public int Charisma {
        get { return chari; }
        set { chari = value; }
    }
}

using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    private String characterClassName;
    private String characterClassDescription;
    
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

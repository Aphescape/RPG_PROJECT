using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BaseCharacterClass;

public class CharacterClass {

    public String name;
    public BaseCharacterClass job;
    public int level;
    //public int exp;
    public int str, dex, con, wis, inte, chari;

    public CharacterClass (string charName, string charJob) {
        name = charName;
        job = new BaseCharacterClass(charJob);
        level = 1;
        //exp = 0;
        str = 0;
        dex = 0;
        con = 0;
        wis = 0;
        inte = 0;
        chari = 0;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public BaseCharacterClass Job
    {
        get { return job; }
        set { job = value; }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public int Strenght
    {
        get { return str; }
        set { str = value; }
    }
    public int Dexterity
    {
        get { return dex; }
        set { dex = value; }
    }
    public int Constitution
    {
        get { return con; }
        set { con = value; }
    }
    public int Wisdom
    {
        get { return wis; }
        set { wis = value; }
    }
    public int Intelligence
    {
        get { return inte; }
        set { inte = value; }
    }
    public int Charisma
    {
        get { return chari; }
        set { chari = value; }
    }
}
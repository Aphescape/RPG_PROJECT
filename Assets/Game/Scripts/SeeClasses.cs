using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static BaseCharacterClass;

public class SeeClasses {
    
    public BaseCharacterClass class1 = new BaseCharacterClass("barbarian");
    //public BaseCharacterClass class2 = new BaseCharacterClass().BarbarianClass();

    //private BaseCharacterClass class2 = new GameClasses.DruidClass();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGUI(){
        SceneManager.LoadScene("Classes");

    }
}

using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static BaseCharacterClass;
using static GameClasses;

public class SeeClasses : GameClasses
{
    private BaseCharacterClass class1 = new FigherClass();
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

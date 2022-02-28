using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeeClasses : MonoBehaviour
{
    private BaseCharacterClass class1 = new FighterClass();
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

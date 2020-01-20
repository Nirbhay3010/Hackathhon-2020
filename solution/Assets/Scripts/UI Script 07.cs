﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works
    }
    private void SubmitName(string arg0)
    {
        Debug.Log(arg0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

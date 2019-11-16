﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShinyCounter : MonoBehaviour
{
    [ReadOnlyField]
    public int shinyCount;
    public Text shinyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shinyText.text = "Shinies encountered: " + shinyCount.ToString();
    }
}

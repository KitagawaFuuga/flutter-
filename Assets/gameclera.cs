﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclera : MonoBehaviour
{
    float times =0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        times += Time.deltaTime;
        if(times >= 60)
            SceneManager.LoadScene("gameclear");
        
    }
}

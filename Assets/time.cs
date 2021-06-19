using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    GameObject timel;
    float timee = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        timel = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        this.timee -= Time.deltaTime;
        timel.GetComponent<Text>().text = this.timee.ToString("F1");                                                        
    }
}

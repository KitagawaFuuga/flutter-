using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finshbotton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    } 
}

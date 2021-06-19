using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class go : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene("gamescean");
    }
}

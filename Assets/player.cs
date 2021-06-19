using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public AudioClip sound;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x <= -2)
                this.gameObject.transform.position = new Vector3(2,-2,0);
            else{    
                this.gameObject.transform.Translate(-1,0,0);
            }
        }else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x >= 2)
                this.gameObject.transform.position = new Vector3(-2,-2,0);
            else{
            this.gameObject.transform.Translate(1,0,0);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(sound);
    }

    
}

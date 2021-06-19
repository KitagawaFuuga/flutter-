using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{

    float countup = 0.0f;

    int count;

    public GameObject Object;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countup += Time.deltaTime;
            if(count <= 5)
            {
                if(countup >= 3.0)
                {
                    int random = Random.Range(-2,2);
                    Instantiate(Object,new Vector3(random,5,0), Quaternion.identity);
                    countup = 0;
                    this.count++;
                }
            }

            if(count <= 10 && count > 5)
            {
                if(countup >= 2.0)
                {
                    int random = Random.Range(-2,2);
                    Instantiate(Object,new Vector3(random,5,0), Quaternion.identity);
                    countup = 0;
                    this.count++;
                }
            }
            
            if(count <= 20 && count > 10)
            {
                if(countup >= 1.5)
                {
                    int random = Random.Range(-2,2);
                    Instantiate(Object,new Vector3(random,5,0), Quaternion.identity);
                    countup = 0;
                    this.count++;
                }
            }

            if(count <= 30 && count > 20)
            {
                if(countup >= 1)
                {
                    int random = Random.Range(-2,2);
                    Instantiate(Object,new Vector3(random,5,0), Quaternion.identity);
                    countup = 0;
                    this.count++;
                }
            }

            if(count <= 40 && count > 30)
            {
                if(countup >= 0.5)
                {
                    int random = Random.Range(-2,2);
                    Instantiate(Object,new Vector3(random,5,0), Quaternion.identity);
                    countup = 0;
                    this.count++;
                }
            }
            if(countup> 60)
            {
                SceneManager.LoadScene("gameclear");
            }
    }
}

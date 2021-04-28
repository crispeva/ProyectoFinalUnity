using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public float firerate = 0.5f;
    float nextfire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.R) && Time.time>nextfire)
        {
            

            nextfire = Time.time + firerate;
            fire();
                

        }
    }

    void fire()
    {
        Instantiate(bala, transform.position, Quaternion.identity);
    }
}

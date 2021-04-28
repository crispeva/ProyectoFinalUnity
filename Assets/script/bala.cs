using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    private Rigidbody2D Myrb;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
       
        Myrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
        Myrb.velocity = new Vector2(+Speed,0);
        Destroy(gameObject, 5f);
    }
}

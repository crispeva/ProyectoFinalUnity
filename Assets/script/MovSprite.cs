using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovSprite : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpPower = 20f;
    private bool jump;
    private Animator animator;
    private bool Grounded;

    public float velocidad = 10f;
    private float direccion;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("saltando",true);
            rb2d.AddForce(new Vector2(0, jumpPower));
           
        }
       

    }
  
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            animator.SetBool("saltando", false);
        }
    }
   
}

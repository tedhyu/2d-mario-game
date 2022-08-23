using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour 
{
    public float speed;
    public float jumpForce;
    private bool canMove;
    private Rigidbody2D theRB2D;


    // Start is called before the first
    // frame update
    void Start()
    {
        theRB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
  //  void Update()
    //{}
}
//private void fixedUpdate()
//{}
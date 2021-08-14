using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class birdmotion : MonoBehaviour
{
    private bool jumpKeyWasPressed = false;
    private Rigidbody rigidbodycomponent;
    private Transform transformx;
    public float Jumpoint = 1f;
    public GameController Controller;
    public GameObject cmv;



    void Start()
    {
        rigidbodycomponent = GetComponent<Rigidbody>();
        transformx = GetComponent<Transform>();
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
  
    }

    private void FixedUpdate()
    {
        

        if (jumpKeyWasPressed)
        {
            rigidbodycomponent.velocity = Vector3.up * Jumpoint;
            cmv.SetActive(false);
            jumpKeyWasPressed = false;
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        Controller.gameover();
    }



}

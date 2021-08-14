using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemotion : MonoBehaviour
{
    private Transform tran;
    public float move = 2f;

    void Start()
    {
        tran = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        tran.position = tran.position + new Vector3(-1 * move, 0f, 0);
    }
    
}

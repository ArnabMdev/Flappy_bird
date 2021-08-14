using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float maxtime = 1;
    private float timer = 1;
    public GameObject pipes;
    public float hieght;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxtime)
        {
            GameObject newpipe = Instantiate(pipes);
            newpipe.transform.position =  newpipe.transform.position + new Vector3(0f, Random.Range(-hieght,5), 0);
            Destroy(newpipe, 15);
            timer = 0;
        }
         timer += Time.deltaTime;
    }
}

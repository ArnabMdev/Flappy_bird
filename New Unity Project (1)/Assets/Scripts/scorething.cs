using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorething : MonoBehaviour
{
    public static int score = 0;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = score.ToString();
    }

    
}

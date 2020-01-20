using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float scoreAmount;
    public float pointDecreasedPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointDecreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreAmount += pointDecreasedPerSecond * Time.deltaTime;  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ibt : MonoBehaviour
{
    public float timeLeft = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        /*Debug.Log(timeLeft);*/
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        }
    }
}

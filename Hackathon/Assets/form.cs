using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class form : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void nex()
    {

        SceneManager.LoadScene("weekly", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rball : MonoBehaviour
{
    public Sprite a;
    public Rigidbody2D mb;
    public Text tex;
    public int pas;
    
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("main ball").GetComponent<Sprite>();
        mb = GameObject.Find("main ball").GetComponent<Rigidbody2D>();
        tex = GameObject.Find("nirbhayloled").GetComponent<Text>();
    }

    void OnMouseDown()
    {
        tex.text = "Yes this iz a";
    }
    

    // Update is called once per frame
    void Update()
    {
        
       
    }
}

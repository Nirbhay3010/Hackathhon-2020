using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wball : MonoBehaviour
{
    public Sprite b;
    public Sprite c;
    public Rigidbody2D wb1;
    public Rigidbody2D wb2;
    public Text tex;
    public int pas;

    // Start is called before the first frame update
    void Start()
    {
        b = GameObject.Find("wb1").GetComponent<Sprite>();
        wb1 = GameObject.Find("wb1").GetComponent<Rigidbody2D>();
        c = GameObject.Find("wb2").GetComponent<Sprite>();
        wb2 = GameObject.Find("wb2").GetComponent<Rigidbody2D>();
        tex = GameObject.Find("nirbhayloled").GetComponent<Text>();
    }

    void OnMouseDown()
    {
        tex.text = "Yes this iz not a";
    }


    // Update is called once per frame
    void Update()
    {


    }
}

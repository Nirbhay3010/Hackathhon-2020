using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;






public class spotit : MonoBehaviour
{


    public Sprite a;
    public Sprite b;
    public Sprite c;
    public Vector3 velocity;
    public Rigidbody2D mb;
    public Rigidbody2D wb1;
    public Rigidbody2D wb2;
    public float timeLeft = 1000f;
    public int pass = 0;


    // Start is called before the first frame update
    void Awake()
    {
        a = GameObject.Find("main ball").GetComponent<Sprite>();
        mb = GameObject.Find("main ball").GetComponent<Rigidbody2D>();
        b = GameObject.Find("wb1").GetComponent<Sprite>();
        wb1 = GameObject.Find("wb1").GetComponent<Rigidbody2D>();
        c = GameObject.Find("wb2").GetComponent<Sprite>();
        wb2 = GameObject.Find("wb2").GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


        timeLeft -= Time.deltaTime;
        /*Debug.Log(timeLeft);*/
        if (timeLeft < 0)
        {
            stopitlol();
            pass = 1;

        }


    }



    public void red()
    {
        timeLeft = 25f;
        Debug.Log("1");
        int a1 = Random.Range(300, 1000);
        int a2 = Random.Range(-300, 1000);
        int b1 = Random.Range(-1000, 300);
        int b2 = Random.Range(-1500, -1000);
        int c1 = Random.Range(600, 1000);
        int c2 = Random.Range(900, 1500);

        Physics2D.IgnoreCollision(GameObject.Find("main ball").GetComponent<Collider2D>(), GameObject.Find("wb1").GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(GameObject.Find("main ball").GetComponent<Collider2D>(), GameObject.Find("wb2").GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(GameObject.Find("wb1").GetComponent<Collider2D>(), GameObject.Find("wb2").GetComponent<Collider2D>());
        mb.velocity = new Vector3(a1, a2, 0);
        wb1.velocity = new Vector3(b1, b2, 0);
        wb2.velocity = new Vector3(c1, c2, 0);
    }
    

    public void stopitlol()
    {
        mb.velocity = Vector3.zero;
        wb1.velocity = Vector3.zero;
        wb2.velocity = Vector3.zero;

    }
}

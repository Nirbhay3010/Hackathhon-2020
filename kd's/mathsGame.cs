using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mathsGame : MonoBehaviour
{
    public int usr;
    public GameObject inputField;
    public GameObject ansDisplay;
    public GameObject number1;
    public GameObject number2;
    public GameObject oper;
    public int ans = 0;
    public int i = 0;
    // Start is called before the first frame update
    void Awake()
    {
   
        char op = '0';
        
        //bool gameOver = false;
            I1:
            int a = Random.Range(1, 20);
            int b = Random.Range(1, 20);
            int l = Random.Range(1, 4);
            switch (l)
            {
                case 1:
                    op = '+';
                    ans = a + b;
                    break;
                case 2:
                    op = '-';
                    ans = a - b;
                    break;
                case 3:
                    op = '*';
                    ans = a * b;
                    break;
                case 4:
                    op = '/';
                    ans = a / b;
                    break;
                default:
                    Debug.Log("err");
                    break;
            }

            i++;
            Debug.Log(i);

            number1.GetComponent<Text>().text = a.ToString();
            number2.GetComponent<Text>().text = b.ToString();
            oper.GetComponent<Text>().text = op.ToString();


           




        

    }


    public void res()
    {
       
        usr = int.Parse(inputField.GetComponent<Text>().text);


        if (usr == ans)
        {
            ansDisplay.GetComponent<Text>().text = "gg";

        }
        else
        {
            ansDisplay.GetComponent<Text>().text = "u sucks lmao";
        }

        if (i < 10)
        {
            Awake();
        }
    }
}
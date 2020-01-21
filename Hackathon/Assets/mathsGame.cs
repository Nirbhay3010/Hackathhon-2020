using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mathsGame : MonoBehaviour
{
    public int usr;
    public InputField inputField;
    public GameObject ansDisplay;
    public GameObject number1;
    public GameObject number2;
    public GameObject oper;
    public int ans = 0;
    public int i = 0;
    // Start is called before the first frame update
    void Awake()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        char op = '0';
        
        //bool gameOver = false;
            
            int a_s = Random.Range(1, 50);
            int b_s = Random.Range(1, 50);
            int a_m = Random.Range(1, 10);
            int b_m = Random.Range(1, 10);
        int a_sub = Random.Range(8, 40);
        int b_sub = Random.Range(1, 25);
        int a_d = Random.Range(10, 50);
        int b_d = Random.Range(2, 10);
        int l = Random.Range(1, 5);
            switch (l)
            {
                case 1:
                    op = '+';
                    ans = a_s + b_s;
                number1.GetComponent<Text>().text = a_s.ToString();
                number2.GetComponent<Text>().text = b_s.ToString();
                break;
                case 2:
                    op = '-';
                    ans = a_sub - b_sub;
                number1.GetComponent<Text>().text = a_sub.ToString();
                number2.GetComponent<Text>().text = b_sub.ToString();
                break;
                case 3:
                    op = 'x';
                    ans = a_m * b_m;
                number1.GetComponent<Text>().text = a_m.ToString();
                number2.GetComponent<Text>().text = b_m.ToString();
                break;
                case 4:
                op = '/';
                if (a_d % b_d == 0)
                {
                    
                    ans = a_d / b_d;
                    number1.GetComponent<Text>().text = a_d.ToString();
                    number2.GetComponent<Text>().text = b_d.ToString();
                }
                else
                {
                    a_d -= a_d % b_d;
                    ans = a_d / b_d;
                    number1.GetComponent<Text>().text = a_d.ToString();
                    number2.GetComponent<Text>().text = b_d.ToString();
                }
                break;
                default:
                    Debug.Log("err");
                    break;
            }

            i++;
            Debug.Log(i);

            
            oper.GetComponent<Text>().text = op.ToString();


           




        

    }
    public void useans()
    {

        usr = int.Parse(inputField.text); 
        

    }

    public void res()
    {
       
        



        if (usr == ans)
        {
            ansDisplay.GetComponent<Text>().text = "Right";

        }
        else
        {
            ansDisplay.GetComponent<Text>().text = "Wrong";
        }

        if (i < 10)
        { 
            Awake();
            inputField.text = "";
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class form : MonoBehaviour
{ 
    public InputField inputField1;
    public InputField inputField2;
    public Dropdown dropdown;
    public Dropdown dropdown1;
    public Text m_Text;


    // Start is called before the first frame update
    void Start()
    {
    inputField1 = GameObject.Find("InputField").GetComponent<InputField>();
        inputField2 = GameObject.Find("InputFieldAge").GetComponent<InputField>();
        dropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        dropdown1 = GameObject.Find("Dropdown (1)").GetComponent<Dropdown>();

        float age_score,Gender_score,location_score;
        string gender = dropdown.options[dropdown.value].text;
        string location = dropdown1.options[dropdown1.value].text;
        if (int.Parse(inputField2.text) <= 65)
        {
            age_score = 1.0f;
        }
        else
        {
            age_score = 1 / 28f;
        }

        if (gender=="Female")
        {
            Gender_score = 0.66f;
        }
        else
        {
            Gender_score = 1.0f;
        }

        if(location=="North America" || location=="Europe")
        {
            location_score = 0.975f;
        }
        else if(location=="South America")
        {
            location_score = 0.75f;
        }
        else
        {
            location_score = 0.5f;
        }

        string conn = "URI=file:" + Application.dataPath + "/PickAndPlaceDatabase.s3db"; //Path to database.
    IDbConnection dbconn;
    dbconn = (IDbConnection)new SqliteConnection(conn);
    dbconn.Open(); //Open connection to the database.
    IDbCommand dbcmd = dbconn.CreateCommand();
    string sqlQuery = "CREATE TABLE IF NOT EXISTS my_table231 (name char[20],age int,age_score decimal[5,5],Location char[20],location decimal[4,4],Gender Char,Gender_Score decimal[2,2];";
    dbcmd.CommandText = sqlQuery;
    IDataReader reader = dbcmd.ExecuteReader();
    IDbCommand cmnd = dbconn.CreateCommand();
    cmnd.CommandText = "INSERT INTO my_table231 VALUES('" + inputField1 + "'," + int.Parse(inputField2.text) + "," + age_score + ",'" + location + "'," + location_score + ",'" + gender + "'," + Gender_score + ");";
    cmnd.ExecuteNonQuery();
    IDbCommand cmnd_read = dbconn.CreateCommand();
    string query = "SELECT  FROM my_table231";
    cmnd_read.CommandText = query;
    reader = cmnd_read.ExecuteReader();
    //while (reader.Read())
    //{
    // Debug.Log("id: " + reader[0].ToString());
    // Debug.Log("val: " + reader[1].ToString());
    //}
    dbconn.Close();
    /* while (reader.Read())
     {
         int value = reader.GetInt32(0);
         string name = reader.GetString(1);
         int rand = reader.GetInt32(2);

         Debug.Log("value= " + value + "  name =" + name + "  random =" + rand);
     }
     reader.Close();
     reader = null;
     dbcmd.Dispose();
     dbcmd = null;
     dbconn.Close();
     dbconn = null;*/
    //or simply use the line below, 
    //input.onEndEdit.AddListener(SubmitName);  // This also works


public void SubmitName(string arg0)
    {
        Debug.Log(arg0);
    }
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

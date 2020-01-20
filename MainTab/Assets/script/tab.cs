using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tab : MonoBehaviour
{
    //This function should be called through the button's OnClick
    public void SaveLevel(int id)
    {
        PlayerPrefs.SetInt("level", id);
    }

    // Start is called before the first frame update
 
        public class LevelLock : MonoBehaviour
        {
               //This field should be set by the inspector
               [SerializeField] int levelRequirement;
             public void Start()
             {
                int currentLevel = PlayerPrefs.GetInt("level");
                bool levelUnlocked = currentLevel >= levelRequirement;
                GetComponent<Button>().interactable = levelUnlocked;
             }
        }

       // Update is called once per frame
        void Update()
        {
        
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playgame : MonoBehaviour
{
    public string activeWord;
    
    public Text prefab;
    public GameObject square;

    public Text text;
    
    public Text pausetxt;

    public InputField AN;

    public bool pause = false;

    public float fall = 1f;

    public static int wordR = 0;

    public string word;

     private string[] wordarray = {"help", "hello","greeting","up","down","left","right","front","back","below","behind","over","frenzy","popcorn","cereal"};

    public void Start()
    {
        pausetxt.gameObject.SetActive(false);
        
    }

    public void CheckIn()
    {
        activeWord = text.text;

        if(AN.text == activeWord)
        {
             text.gameObject.SetActive(false);
             AN.text = " ";
             wordR++;
             spawn();

        }
    }
    public void Update()
    {
        
        if(Input.GetKeyDown("escape"))
        {
            if(pause == false)
            {
                fall = 0f;
                pausetxt.gameObject.SetActive(true);
                pause = true;
            }else{
                fall = 1f;
                pausetxt.gameObject.SetActive(false);
                pause = false;
            }
        }
    }
    public void spawn()
    {
        Instantiate(prefab);
        prefab.transform.position = square.transform.position;
        word = wordarray[Random.Range(0,15)];
        prefab.text= word;
    }
}

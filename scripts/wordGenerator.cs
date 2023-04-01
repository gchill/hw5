using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class wordGenerator : MonoBehaviour
{
  
  public static string[] wordarray = {"help", "hello","greeting","up","down","left","right","front","back","below","behind","over","frenzy","popcorn","cereal"};

   public static string GetRandomWord()
   {
      string randomWord = wordarray[Random.Range(0,15)] ;
    return randomWord;
   }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
  public static string playerName;

  public InputField nameIN;

  public Text endtxt;

    void Start()
    {
        endtxt.text = ("thanks for playing " + playerName + "there were " + playgame.wordR + "used and you got "+ playgame.wordR + "right");
    }
    public void name()
    {
        playerName = nameIN.text;
        Debug.Log(playerName);
    }
}

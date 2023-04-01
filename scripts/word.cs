using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word 
{
    public string word1;
    private static int typeindex;

    public void word(string _word)
    {
        word1 = _word;
        typeindex = 0;
    }
    public char getNextLetter()
    {
        return word1[typeindex];
    }
    public static void typeletter()
    {
        typeindex++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wordmanager : MonoBehaviour
{
   public List<Word> word ;

   private bool hasActiveWord;

   private Word activeWord;

   public GameObject prefab;

   private static int typeindex;

   public int wordcount;

   public Text text1;
   public Text text2;
   

   private void Start()
   {
    addword();
    addword();
    addword();
    addword();
   }
   public void addword()
   {
    Word words = new Word();
    word.Add(words);
    text1.text = wordGenerator.GetRandomWord();
    text2.text = wordGenerator.GetRandomWord();
   }
   public void typeletter(char letter)
   {
      if(hasActiveWord)
      {
         if(activeWord.getNextLetter() == letter)
         {
            
         }
      }else
      {
         foreach(Word words in word)
         {
            activeWord = words;
            hasActiveWord = true;
            Word.typeletter();
            break;
         }
      }
   }
}

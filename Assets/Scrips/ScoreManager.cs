using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   int score = 0;
   public Text scoreText;

   public void RaiseScore(int s){
       score += s;
       scoreText.text = score + "";
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Score;
    public int scoreCount = 0;

    private void Start(){
        Score = GameObject.Find("Score").GetComponent<Text>();
        Score.text = ("Collectibles: " + scoreCount + "/12");
    }

    public void changeText(int upScore){
        scoreCount = scoreCount + upScore;
        Score.text = ("Collectibles: " + scoreCount + "/12");
    }
}

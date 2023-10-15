using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   // The score value of this collectible.
    public Text Score;

    private void Start(){
        Score = GameObject.Find("Score").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase the player's score when the collectible is collected.
            Score.GetComponent<ChangeText>().changeText(1);

            // Destroy the collectible game object.
            Destroy(gameObject);
        }
    }
}

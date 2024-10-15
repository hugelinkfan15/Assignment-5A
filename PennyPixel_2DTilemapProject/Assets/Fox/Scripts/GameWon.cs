using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWon : MonoBehaviour
{
    public ScoreManager sM;
    public Text winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(sM.score == 10)
            {
                winText.text = "You Win!\nPress R to restart!";
                sM.won = true;
            }
            else
            {
                winText.text = "You need 10 gems to Win!";
            }
        }
    }
}

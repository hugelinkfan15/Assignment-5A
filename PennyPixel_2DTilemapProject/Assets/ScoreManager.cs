/*
* Kayden Miller
* ScoreManager
* Assignment 5A
* Used to manage score and win bool
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public bool won;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if(won && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

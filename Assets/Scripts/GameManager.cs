using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public float xRange;
    public float yRange;
    public GameObject gameOver;
    public TextMeshProUGUI scoreText;
    public bool gameActive;
    public GameObject mainMenu;
    public float wispNumber;
    public float delay = 3;
    public float interval = 3;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameActive=false;
        Time.timeScale = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score < -10) { gameOver.SetActive(true);gameActive = false; Time.timeScale = 0; }
        
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "score: " + score;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame() { SceneManager.SetActiveScene(SceneManager.GetSceneByName("GameScene"));mainMenu.SetActive(false); Time.timeScale = 1; gameActive = true; }
    

    



}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public Text scoreText; // ≈‘ß°Ï°—∫ Text UI „π Inspector
    public int winScore = 100;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "" + score; // Õ—ª‡¥µ¢ÈÕ§«“¡§–·ππ

       
        if (score >= winScore)
        {
            SaveScoreAndLoadWinScene();
        }
    }
    
    void SaveScoreAndLoadWinScene()
    {
        PlayerPrefs.SetInt("FinalScore", score); // ∫—π∑÷°§–·ππ„π PlayerPrefs
        SceneManager.LoadScene("GameWin"); // ‚À≈¥©“° GameWin
    }
}


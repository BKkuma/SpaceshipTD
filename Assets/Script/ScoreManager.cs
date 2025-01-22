using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public Text scoreText; // �ԧ��Ѻ Text UI � Inspector
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
        scoreText.text = "" + score; // �ѻവ��ͤ�����ṹ

       
        if (score >= winScore)
        {
            SaveScoreAndLoadWinScene();
        }
    }
    
    void SaveScoreAndLoadWinScene()
    {
        PlayerPrefs.SetInt("FinalScore", score); // �ѹ�֡��ṹ� PlayerPrefs
        SceneManager.LoadScene("GameWin"); // ��Ŵ�ҡ GameWin
    }
}


using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public Text scoreText; // �ԧ��Ѻ Text UI � Inspector

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
    }
}


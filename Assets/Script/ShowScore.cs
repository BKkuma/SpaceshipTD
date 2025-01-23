using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText; // �ԧ��Ѻ Text UI � Inspector

    void Start()
    {
        // �֧��ṹ�ҡ ScoreManager ����ʴ���
        int finalScore = ScoreManager.instance.score; // �֧��ṹ�ҡ ScoreManager
        scoreText.text = "Your Score: " + finalScore;
    }
}

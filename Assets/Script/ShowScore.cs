using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText; // �ԧ��Ѻ Text UI � Inspector

    void Start()
    {
        // �֧��ṹ�ҡ PlayerPrefs ����ʴ���
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0); // ���������鹤�� 0 �ҡ����բ�����
        scoreText.text = "Your Score: " + finalScore;
    }
}

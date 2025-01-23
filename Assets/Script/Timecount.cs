using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ����Ѻ�����ҹ UI

public class Timer : MonoBehaviour
{
    public Text timerText; // ���������Ѻ�������͡Ѻ Text UI
    private float timePlayed = 0f; // ����������ҷ������

    void Update()
    {
        // �������ҷء���駷�� Update
        timePlayed += Time.deltaTime;

        // �ѻവ UI ����ʴ�����
        UpdateTimeText();
    }

    // �ѧ��ѹ�ѻവ����ʴ�������
    void UpdateTimeText()
    {
        // �ŧ�����繹ҷ�����Թҷ�
        int minutes = Mathf.FloorToInt(timePlayed / 60f); // �ҷ�
        int seconds = Mathf.FloorToInt(timePlayed % 60f); // �Թҷ�

        // �ʴ���������ٻẺ "�ҷ�:�Թҷ�"
        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}

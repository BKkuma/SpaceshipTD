using System;
using UnityEngine;
using UnityEngine.UI; // ����Ѻ�����ҹ UI

public class RealTimeTimer : MonoBehaviour
{
    public Text timerText; // �������͡Ѻ Text UI �����ʴ�����
    private DateTime startTime; // �����ҷ���������

    void Start()
    {
        // �ѹ�֡���һѨ�غѹ������������
        startTime = DateTime.Now;
    }

    void Update()
    {
        // �ӹǳ���ҷ���ҹ��
        TimeSpan elapsedTime = DateTime.Now - startTime;

        // �ѻവ UI ����ʴ�����
        UpdateTimeText(elapsedTime);
    }

    // �ѧ��ѹ�ѻവ����ʴ�������
    void UpdateTimeText(TimeSpan elapsedTime)
    {
        // �ŧ�����繪������:�ҷ�:�Թҷ�
        timerText.text = string.Format("Time: {0:D2}:{1:D2}:{2:D2}",
            elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    public Text timeText; // �ԧ��Ѻ Text UI � Inspector

    void Start()
    {
        // �֧���ҷ��ѹ�֡���ҡ PlayerPrefs
        string finalTime = PlayerPrefs.GetString("FinalTime", "00:00:00"); // ���������鹤�� "00:00:00" �ҡ����բ�����

        // �ʴ�������� UI
        timeText.text = "Time Played: " + FormatTime(finalTime);

        // ź�����ŷ��ѹ�֡�����ѧ�ʴ���
        PlayerPrefs.DeleteKey("FinalTime");
    }

    // �ѧ��ѹ����Ѻ����ŧ����������ٻẺ�������:�ҷ�:�Թҷ�
    string FormatTime(string timeString)
    {
        // �ŧ�ҡ TimeSpan string �� TimeSpan object
        TimeSpan time = TimeSpan.Parse(timeString);

        // �ӹǳ�������, �ҷ� ��� �Թҷ�
        int hours = time.Hours;
        int minutes = time.Minutes;
        int seconds = time.Seconds;

        // �׹�����ٻẺ�������ʴ�����Թҷ�
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}

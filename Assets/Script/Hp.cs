using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ���������ҹ UI
using UnityEngine.SceneManagement; // ����Ѻ�����Ŵ�ҡ

public class Hp : MonoBehaviour
{
    public int hp = 10; // ��˹���� HP �������
    public Text hpText; // �������������ҧ�ԧ��ѧ Text UI

    // ���¡��ҹ������Դ��ê���� 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ��Ǩ�ͺ��� GameObject ��誹���� "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp -= 1; // Ŵ HP ŧ 1
            Debug.Log("HP Ŵŧ: " + hp);

            // �ѻവ����ʴ��� HP
            UpdateHPText();

            // �ҡ HP ���¡���������ҡѺ 0
            if (hp <= 0)
            {
                Debug.Log("Game Over!");
                LoadGameWinScene(); // ��Ŵ�ҡ GameWin
            }
        }
    }

    void LoadGameWinScene()
    {
        SceneManager.LoadScene("GameWin"); // ��Ŵ�ҡ��������� "GameWin"
    }

    // �ѧ��ѹ�����ѻവ��� HP � UI
    void UpdateHPText()
    {
        if (hpText != null)
        {
            hpText.text = "HP: " + hp.ToString(); // �ʴ���� HP � Text UI
        }
    }
}

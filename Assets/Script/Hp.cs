using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int hp = 10; // ��˹���� HP �������

    // ���¡��ҹ������Դ��ê���� 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ��Ǩ�ͺ��� GameObject ��誹���� "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp -= 1; // Ŵ HP ŧ 1
            Debug.Log("HP Ŵŧ: " + hp);

            // �ҡ HP ���¡���������ҡѺ 0
            if (hp <= 0)
            {
                Debug.Log("Game Over!");
                // ������ҧ: ����� GameObject �ͧ������
                Destroy(gameObject);
            }
        }
    }
}

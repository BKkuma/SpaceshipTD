using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyType2 : MonoBehaviour
{
    public GameObject enemyType2Prefab; // Prefab �ͧ Enemytype2
    public float spawnInterval = 10f;   // ���ҷ����㹡���Դ���е��
    public Transform[] spawnPoints;     // �ش��� Enemytype2 ���Դ (���͡Ẻ����)

    void Start()
    {
        // ���¡�ѧ��ѹ SpawnEnemyType2 ��ӷء� spawnInterval �Թҷ�
        InvokeRepeating(nameof(SpawnEnemyType22), 0f, spawnInterval);
    }

    public void SpawnEnemyType22()
    {
        if (spawnPoints.Length == 0) return; // �������ըش�Դ ��� return �͡�

        int randomIndex = Random.Range(0, spawnPoints.Length); // ���͡�ش�ԴẺ����
        Instantiate(enemyType2Prefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}

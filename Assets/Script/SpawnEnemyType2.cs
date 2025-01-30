using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyType2 : MonoBehaviour
{
    public GameObject enemyType2Prefab; // Prefab �ͧ Enemytype2
    public float spawnInterval = 10f;   // ���ҷ����㹡���Դ���е��
    public Transform[] spawnPoints;     // �ش��� Enemytype2 ���Դ (���͡Ẻ����)

    private GameObject currentEnemy;    // ������� Enemytype2 ���١ Spawn

    void Start()
    {
        // ���¡�ѧ��ѹ SpawnEnemyType2 �ء � spawnInterval �Թҷ�
        InvokeRepeating(nameof(SpawnEnemyType22), 0f, spawnInterval);
    }

    void SpawnEnemyType22()
    {
        // ������� Enemytype2 ���������������
        if (currentEnemy != null) return; // ������������� �����ش�ӧҹ�ѹ��

        if (spawnPoints.Length == 0) return; // �������ըش�Դ ��� return �͡�

        int randomIndex = Random.Range(0, spawnPoints.Length); // ���͡�ش�ԴẺ����
        currentEnemy = Instantiate(enemyType2Prefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
    public void ResetSpawn()
    {
        currentEnemy = null; // ��ҧ��ҵ����������� Spawn ���������
    }

}

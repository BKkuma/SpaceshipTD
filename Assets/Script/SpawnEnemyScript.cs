using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab �ͧ�ѵ��
    public Transform spawnPoint;  // ���˹�������鹷���ѵ�٨��Դ
    public float spawnInterval = 2f; // �������������ҧ������ҧ�ѵ�����Ф���

    // Start is called before the first frame update
    void Start()
    {
        // ������ѧ��ѹ SpawnEnemy ���� ������ҷ���˹�
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // ���ҧ�ѵ�ٷ����˹觢ͧ spawnPoint
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}

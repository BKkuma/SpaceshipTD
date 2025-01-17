using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab �ͧ�ѵ��
    public Transform spawnPoint;  // ���˹�������鹷���ѵ�٨��Դ
    public float spawnInterval = 2f; // �������������ҧ������ҧ�ѵ�����Ф���

    // Start is called before the first frame update

    IEnumerator DecreaseSpawnInterval()
    {
        while (spawnInterval > 0.1f) // ��駤�����Ң�鹵��
        {
            yield return new WaitForSeconds(5f); // Ŵ�������ء� 5 �Թҷ�
            spawnInterval -= 0.1f; // Ŵ����ŧ
            CancelInvoke(nameof(SpawnEnemy));
            InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
            Debug.Log("Spawn Interval Ŵŧ: " + spawnInterval);
        }
    }
    void Start()
    {
        // ������ѧ��ѹ SpawnEnemy ���� ������ҷ���˹�
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
        StartCoroutine(DecreaseSpawnInterval());
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), spawnPoint.position.y, 0f);
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}

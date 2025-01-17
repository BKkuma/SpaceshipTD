using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab ของศัตรู
    public Transform spawnPoint;  // ตำแหน่งเริ่มต้นที่ศัตรูจะเกิด
    public float spawnInterval = 2f; // ระยะเวลาระหว่างการสร้างศัตรูแต่ละครั้ง

    // Start is called before the first frame update

    IEnumerator DecreaseSpawnInterval()
    {
        while (spawnInterval > 0.1f) // ตั้งค่าเวลาขั้นต่ำ
        {
            yield return new WaitForSeconds(5f); // ลดความถี่ทุกๆ 5 วินาที
            spawnInterval -= 0.1f; // ลดเวลาลง
            CancelInvoke(nameof(SpawnEnemy));
            InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
            Debug.Log("Spawn Interval ลดลง: " + spawnInterval);
        }
    }
    void Start()
    {
        // เริ่มฟังก์ชัน SpawnEnemy ซ้ำๆ ตามเวลาที่กำหนด
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
        StartCoroutine(DecreaseSpawnInterval());
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), spawnPoint.position.y, 0f);
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}

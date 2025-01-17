using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab ของศัตรู
    public Transform spawnPoint;  // ตำแหน่งเริ่มต้นที่ศัตรูจะเกิด
    public float spawnInterval = 2f; // ระยะเวลาระหว่างการสร้างศัตรูแต่ละครั้ง

    // Start is called before the first frame update
    void Start()
    {
        // เริ่มฟังก์ชัน SpawnEnemy ซ้ำๆ ตามเวลาที่กำหนด
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // สร้างศัตรูที่ตำแหน่งของ spawnPoint
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}

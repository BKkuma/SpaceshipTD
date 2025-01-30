using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyType2 : MonoBehaviour
{
    public GameObject enemyType2Prefab; // Prefab ของ Enemytype2
    public float spawnInterval = 10f;   // เวลาที่ใช้ในการเกิดแต่ละตัว
    public Transform[] spawnPoints;     // จุดที่ Enemytype2 จะเกิด (เลือกแบบสุ่ม)

    void Start()
    {
        // เรียกฟังก์ชัน SpawnEnemyType2 ซ้ำทุกๆ spawnInterval วินาที
        InvokeRepeating(nameof(SpawnEnemyType22), 0f, spawnInterval);
    }

    public void SpawnEnemyType22()
    {
        if (spawnPoints.Length == 0) return; // ถ้าไม่มีจุดเกิด ให้ return ออกไป

        int randomIndex = Random.Range(0, spawnPoints.Length); // เลือกจุดเกิดแบบสุ่ม
        Instantiate(enemyType2Prefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}

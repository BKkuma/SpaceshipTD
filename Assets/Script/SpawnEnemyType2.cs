using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyType2 : MonoBehaviour
{
    public GameObject enemyType2Prefab; // Prefab ของ Enemytype2
    public float spawnInterval = 10f;   // เวลาที่ใช้ในการเกิดแต่ละตัว
    public Transform[] spawnPoints;     // จุดที่ Enemytype2 จะเกิด (เลือกแบบสุ่ม)

    private GameObject currentEnemy;    // ตัวแปรเก็บ Enemytype2 ที่ถูก Spawn

    void Start()
    {
        // เรียกฟังก์ชัน SpawnEnemyType2 ทุก ๆ spawnInterval วินาที
        InvokeRepeating(nameof(SpawnEnemyType22), 0f, spawnInterval);
    }

    void SpawnEnemyType22()
    {
        // เช็คว่ามี Enemytype2 อยู่แล้วหรือไม่
        if (currentEnemy != null) return; // ถ้ามีอยู่แล้ว ให้หยุดทำงานทันที

        if (spawnPoints.Length == 0) return; // ถ้าไม่มีจุดเกิด ให้ return ออกไป

        int randomIndex = Random.Range(0, spawnPoints.Length); // เลือกจุดเกิดแบบสุ่ม
        currentEnemy = Instantiate(enemyType2Prefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
    public void ResetSpawn()
    {
        currentEnemy = null; // ล้างค่าตัวแปรเพื่อให้ Spawn ตัวใหม่ได้
    }

}

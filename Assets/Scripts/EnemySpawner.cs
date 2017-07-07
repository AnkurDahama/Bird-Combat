using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public bool isAlive;
    public float SpawnenemyWait;
    public GameObject Enemy;
    void Start()
    {
        isAlive = true;
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()
    {
        while(isAlive)
        {
            for(int i= 0; i <= 10; i++)
            {
                Vector3 where = new Vector3(UnityEngine.Random.Range(-700.0F, 700.0F), UnityEngine.Random.Range(-50.0F, 70.0F), 1443.0F);
                Instantiate(Enemy, where, Enemy.transform.rotation);
                yield return new WaitForSeconds(SpawnenemyWait);
            }
        }
    }
}

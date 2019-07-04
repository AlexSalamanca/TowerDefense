using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WaveManager : MonoBehaviour {
    public Transform enemy;
    public Transform spawnPoint;
    public Text waveCountdown;
    public float spawnTime = 5f;

    private float countdown = 2f;
    private int waveIndex = 0;

    void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = spawnTime;
        }

        countdown -= Time.deltaTime;
        waveCountdown.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}

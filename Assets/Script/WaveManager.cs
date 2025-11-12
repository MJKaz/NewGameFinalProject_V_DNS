using System.Collections;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [Header("References")]
    public EnemySpawner spawner;

    [Header("Wave Settings")]
    public float timeBetweenWaves = 5f;
    public int startingEnemies = 5;
    public int enemiesIncrementPerWave = 2;

    private int currentWave = 0;
    private bool isRunning = false;

    void Start()
    {
        StartCoroutine(HandleWaves());
    }

    private IEnumerator HandleWaves()
    {
        isRunning = true;

        while (isRunning)
        {
            currentWave++;
            Debug.Log($"🌊 Starting Wave {currentWave}");

            // Adjust wave difficulty
            spawner.enemiesPerWave = startingEnemies + (currentWave - 1) * enemiesIncrementPerWave;

            // Start the wave
            spawner.StartWave();

            // Wait for wave to finish
            yield return new WaitUntil(() => spawner.IsWaveComplete());

            Debug.Log($"✅ Wave {currentWave} complete!");
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
}

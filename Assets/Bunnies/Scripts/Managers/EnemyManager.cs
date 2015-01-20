using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{

	public Slider healthBar;                                 // Reference to the UI's health bar.
	public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	
    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {

        if(healthBar.value <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}

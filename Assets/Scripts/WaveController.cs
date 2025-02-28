using UnityEngine;

public class WaveController : MonoBehaviour
{
    private int baseHealth = 10000;
    public int BaseHealth => baseHealth;

    //public List<Transform> spawnPoints = new List<Transform>();
    //public List<Transform> furnitureSpots = new List<Transform>();

    public static WaveController instance;
    private static int enemiesInScene = 0;
    public static int EnemiesInScene => enemiesInScene;
    private static int maxEnemies = 10;
    public static int MaxEnemies => MaxEnemies;
    void awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

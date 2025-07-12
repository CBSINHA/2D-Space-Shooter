using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static Spawn instance;
    [SerializeField] GameObject EnemyPrefab;
    AudioSource audiosource;
    public AudioClip winMusic;
    public bool isOver = false;
    public AudioSource bgmSource;
    private void Awake()
    {
        if (instance == null) instance = this;
        audiosource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        Paida();
    }
    private void Update()
    {
        if (!isOver && ScoreManager.instance.score >= LevelManager.instance.Goal())
        {
            CancelInvoke("InstantiateEnemy");
            ScoreManager.instance.WinPanel.SetActive(true);
            bgmSource.Stop();
            audiosource.PlayOneShot(winMusic,0.5f);
            isOver = true;
            Timer.instance.hasWon();
        }
    }

    void InstantiateEnemy()
    {
        Camera cam = Camera.main;

        float z = 0f; // Assuming 2D game
        float distance = -cam.transform.position.z;

        Vector3 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 topRight = cam.ViewportToWorldPoint(new Vector3(1, 1, distance));

        float x = Random.Range(bottomLeft.x + 1f, topRight.x - 1f);
        float y = Random.Range(bottomLeft.y + 1f, topRight.y - 1f);

        Vector3 spawnPos = new Vector3(x, y, 0);
        Instantiate(EnemyPrefab, spawnPos, Quaternion.identity);
    }


    public void Paida()
    {
        CancelInvoke("InstantiateEnemy");
        InvokeRepeating("InstantiateEnemy", 0, LevelManager.instance.AlienSpawnTime());
    }


}

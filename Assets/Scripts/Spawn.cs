using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static Spawn instance;
    [SerializeField] GameObject EnemyPrefab;
    public bool isOver = false;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        Paida();
    }
    private void Update()
    {
        if (ScoreManager.instance.score >= LevelManager.instance.Goal()) { CancelInvoke("InstantiateEnemy"); ScoreManager.instance.WinPanel.SetActive(true); isOver = true; Timer.instance.hasWon(); }
    }
    void InstantiateEnemy()
    {
        float x = Random.Range(-20.3f,20.3f);
        float y = Random.Range(-3.7f,3.7f);
        Vector3 pos = new Vector3(x,y,0);
        Instantiate(EnemyPrefab,pos,Quaternion.identity);
    }
    public void Paida()
    {
        InvokeRepeating("InstantiateEnemy", 0, LevelManager.instance.AlienSpawnTime());
    }
}

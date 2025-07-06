using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    private void Start()
    {
        InvokeRepeating("InstantiateEnemy", 1f, 1f);
    }
    private void Update()
    {
        if (ScoreManager.instance.score >= 50) { CancelInvoke("InstantiateEnemy"); ScoreManager.instance.WinPanel.SetActive(true); }
    }
    void InstantiateEnemy()
    {
        float x = Random.Range(-20.3f,20.3f);
        float y = Random.Range(-3.7f,3.7f);
        Vector3 pos = new Vector3(x,y,0);
        Instantiate(EnemyPrefab,pos,Quaternion.identity);
    }
}

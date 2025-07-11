using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    public float time;
    [SerializeField] Text timerText;
    bool isRunning = false;
    private void Start()
    {
        tame();
    }
    public void tame()
    {
        time = LevelManager.instance.CurrentLevelTime();
        isRunning = true;
    }
    public void hasWon()
    {
        isRunning = false;
    }
    void Update()
    {
        if (isRunning)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                timerText.text = time.ToString("F0")+"s";
            }
            else { ScoreManager.instance.LoosePanel.SetActive(true); Spawn.instance.CancelInvoke("InstantiateEnemy"); Spawn.instance.isOver = true; }
        }
    }
}

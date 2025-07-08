using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    public float time = 10f;
    [SerializeField] Text timerText;
    bool isRunning = false;
    public void tame()
    {
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
                timerText.text = time.ToString("F2");
            }
            else { ScoreManager.instance.LoosePanel.SetActive(true); Spawn.instance.CancelInvoke("InstantiateEnemy"); }
        }
    }
}

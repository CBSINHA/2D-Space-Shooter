using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public AudioSource bgmSource;
    public AudioClip Audioclip;
    AudioSource Audiosource;
    private void Awake()
    {
        if (instance == null) instance = this;
        Audiosource = GetComponent<AudioSource>();
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
    bool isOver = false; 

    void Update()
    {
        if (isRunning)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                timerText.text = time.ToString("F0") + "s";
            }
            else if (!isOver) 
            {
                isOver = true;
                isRunning = false;

                ScoreManager.instance.LoosePanel.SetActive(true);
                Spawn.instance.CancelInvoke("InstantiateEnemy");
                bgmSource.Stop();
                Audiosource.PlayOneShot(Audioclip, 0.5f); 
                Spawn.instance.isOver = true;
            }
        }
    }
}

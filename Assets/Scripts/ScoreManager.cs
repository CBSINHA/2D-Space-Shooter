using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public GameObject WinPanel;
    public GameObject LoosePanel;
    public int target;
    public Text levelBracket;

    private void Awake()
    {
        if (instance == null) instance = this;
        WinPanel.SetActive(false);
        LoosePanel.SetActive(false);
    }
    [SerializeField] Text ScoreText;
    [HideInInspector]public int score=0;
    private void Start()
    {
        target = LevelManager.instance.Goal();
        ScoreText.text = score.ToString() + "/" + target;
        LevelDetails();
    }
    public void AddScore()
    {
        score+=5;
        ScoreText.text = score.ToString()+"/"+target;
    }
    public void SubtractScore()
    {
        score--;
        ScoreText.text = score.ToString() + "/" + target;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        LevelManager.instance.level++; 
        SceneManager.LoadScene("MainScene");
    }
    public void LevelDetails()
    {
        levelBracket.text = LevelManager.instance.level.ToString();
    }
}

using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public GameObject WinPanel;
    public GameObject LoosePanel;

    private void Awake()
    {
        if (instance == null) instance = this;
        WinPanel.SetActive(false);
        LoosePanel.SetActive(false);
    }
    [SerializeField] Text ScoreText;
    [HideInInspector]public int score=0;
    public void AddScore()
    {
        score+=5;
        ScoreText.text = score.ToString();
    }
    public void SubtractScore()
    {
        score--;
        ScoreText.text = score.ToString();
    }
}

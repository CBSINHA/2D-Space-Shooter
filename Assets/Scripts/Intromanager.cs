using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intromanager : MonoBehaviour
{
    [SerializeField] GameObject UICanvas;
    [SerializeField] GameObject InstructionPanel;
    private void Awake()
    {
        UICanvas.SetActive(true);
        InstructionPanel.SetActive(false);
    }
    public void StartGame()
    {
        Spawn.instance.Paida();
        Timer.instance.tame();
        UICanvas.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Application is quitting.........");
        Application.Quit();
    }
    public void CloseInstructionPanel()
    {
        InstructionPanel.SetActive(false);
    }
    public void OpenInstructionPanel()
    {
        InstructionPanel.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

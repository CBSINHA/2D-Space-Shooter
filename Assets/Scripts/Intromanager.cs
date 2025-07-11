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
        Debug.Log("Start game button click");
        SceneManager.LoadScene("MainScene");
        //Spawn.instance.Paida();
        //Timer.instance.tame();
    }
    public void QuitGame()
    {
        Debug.Log("Application is quitting.........");
        Application.Quit();
    }
    public void CloseInstructionPanel()
    {
        InstructionPanel.SetActive(false);
        Debug.Log("Close instruction panel button click");
    }
    public void OpenInstructionPanel()
    {
        InstructionPanel.SetActive(true);
        Debug.Log("Open instruction panel button click");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Main Menu button click");
    }
}

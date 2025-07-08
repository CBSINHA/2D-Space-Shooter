using System;
using UnityEngine;

public class Intromanager : MonoBehaviour
{
    [SerializeField] GameObject UICanvas;
    [SerializeField] GameObject InstructionPanel;
    private void Awake()
    {
        UICanvas.SetActive(true);
    }
    public void StartGame()
    {
        Spawn.instance.Paida();
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
}

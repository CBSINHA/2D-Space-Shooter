using UnityEngine;

public class Intromanager : MonoBehaviour
{
    [SerializeField] GameObject UICanvas;
    private void Awake()
    {
        UICanvas.SetActive(true);
    }
    public void StartGame()
    {
        Spawn.instance.Paida();
        UICanvas.SetActive(false);
    }
}

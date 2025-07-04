using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 1.5f);
    }
    private void OnMouseDown()
    {
        Debug.Log("Hit");
        Destroy(gameObject);
    }
}

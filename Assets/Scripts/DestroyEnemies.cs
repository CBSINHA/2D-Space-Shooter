using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{
    bool miss = false;
    private void Start()
    {
        Invoke("AutoDestroy", 2.5f);
    }
    void OnMouseDown()
    {
        ScoreManager.instance.AddScore();
        //Debug.Log("Hit");
        Destroy(gameObject,0f);
    }
    void AutoDestroy()
    {
        Destroy(gameObject);
    }
}

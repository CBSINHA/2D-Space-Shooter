using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{
    bool hit = false;
    private void Start()
    {
        Invoke("AutoDestroy", 1.3f);
    }
    void OnMouseDown()
    {
        ScoreManager.instance.AddScore();
        hit = true;
        //Debug.Log("Hit");
        Destroy(gameObject);
    }
    void AutoDestroy()
    {
        if (!hit) ScoreManager.instance.SubtractScore();
        Destroy(gameObject);
    }
}

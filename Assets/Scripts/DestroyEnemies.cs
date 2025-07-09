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
        if (Spawn.instance.isOver) return;
        ScoreManager.instance.AddScore();
        hit = true;
        //Debug.Log("Hit");
        Destroy(gameObject);
    }
    void AutoDestroy()
    {
        if (Spawn.instance.isOver) return;
        if (!hit) ScoreManager.instance.SubtractScore();
        Destroy(gameObject);
    }
}

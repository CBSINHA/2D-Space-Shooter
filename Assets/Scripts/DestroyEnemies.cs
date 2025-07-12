using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{
    bool hit = false;
    [SerializeField] AudioClip audioClip;
    private void Start()
    {
        Invoke("AutoDestroy", LevelManager.instance.AlienDespawnTime());
    }
    void OnMouseDown()
    {
        if (Spawn.instance.isOver) return;
        ScoreManager.instance.AddScore();
        hit = true;

        if (audioClip != null)
        {
            AudioManager.instance.PlaySFX(audioClip);
        }

        Destroy(gameObject);
    }

    void AutoDestroy()
    {
        if (Spawn.instance.isOver) return;
        if (!hit) ScoreManager.instance.SubtractScore();
        Destroy(gameObject);
    }
}

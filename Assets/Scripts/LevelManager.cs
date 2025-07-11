using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }


    [Header("Game Options")]
    public int level = 1;
    public float CurrentAlienSpawnTime, CurrentAlienDespawnTime, CurrentLevelCompleteTime;
    public float DecreaseAlienSpawnTimeBy, DecreaseAlienDespawnTimeBy, DecreaseLevelCompleteTimeBy;
    public int CurrentGoal;
    public int IncreaseGoalBy;


    public float AlienSpawnTime()
    {
        return Mathf.Max(0.4f,CurrentAlienSpawnTime - (level-1)*DecreaseAlienSpawnTimeBy);
    }
    public float AlienDespawnTime()
    {
        return Mathf.Max(0.7f,CurrentAlienDespawnTime - (level - 1) * DecreaseAlienDespawnTimeBy);
    }
    public float CurrentLevelTime()
    {
        return Mathf.Max(22f,CurrentLevelCompleteTime-(level-1)*DecreaseLevelCompleteTimeBy);
    }
    public int Goal()
    {
        return Mathf.Min(200, CurrentGoal + (level - 1) * IncreaseGoalBy);
    }
}

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
    public float DecreaseAlienSpawnTimeBy, DecreaseAlienDespawnTimeBy, IncreastLevelCompleteTimeBy;
    public int CurrentGoal;
    public int IncreaseGoalBy;


    public float AlienSpawnTime()
    {
        return CurrentAlienSpawnTime - (level-1)*DecreaseAlienSpawnTimeBy;
    }
    public float AlienDespawnTime()
    {
        return CurrentAlienDespawnTime - (level - 1) * DecreaseAlienDespawnTimeBy;
    }
    public float CurrentLevelTime()
    {
        return CurrentLevelCompleteTime
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour //singleton and observer
{
    // Singleton instance
    public static ScoreManager Instance { get; private set; }
    public TextMeshProUGUI scoreCounter;
    private int score = 0;
    public int GetScore() => score;
    private void Awake()
    {
        // Enforce Singleton pattern: only one instance exists.
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        scoreCounter.text = "Score - " + score;
        // Subscribe to the target hit event using the EventBus (pub-sub pattern)
        EventBus.OnTargetHit += OnTargetHit;
    }

    private void OnTargetHit(Target target)
    {
        score += 10;
        scoreCounter.text = "Score - " + score;
    }


    private void OnDestroy()
    {
        EventBus.OnTargetHit -= OnTargetHit;
    }
}
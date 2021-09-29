using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton
    static private GameManager instance;
    static public GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("There is no GameManager instance in the scene.");
            }
            return instance;
        }
    }

    private int score = 0;
    public int Score
    {
        get
        {
            return score;
        }
    }

    public int scorePerCoin;

    void Awake()
    {
        if (instance != null)
        {
            // destroy duplicates
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // add scorePerCoin to score when called
    public void ScoreCoin()
    {
        score += scorePerCoin;
    }

}

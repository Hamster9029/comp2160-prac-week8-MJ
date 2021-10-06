using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    // Singleton
    static private Scorekeeper instance;
    static public Scorekeeper Instance
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

    private int scoreP1 = 0;
    public int ScoreP1
    {
        get
        {
            return scoreP1;
        }
    }

    private int scoreP2 = 0;
    public int ScoreP2
    {
        get
        {
            return scoreP2;
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
    public void ScoreCoinP1()
    {
        scoreP1 += scorePerCoin;
    }

    public void ScoreCoinP2()
    {
        scoreP2 += scorePerCoin;
    }

}

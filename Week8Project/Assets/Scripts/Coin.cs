using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // other collider triggered player's collider
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Destroy(gameObject);
            Scorekeeper.Instance.ScoreCoinP1();
        }

        if (collider.tag == "Player2")
        {
            Destroy(gameObject);
            Scorekeeper.Instance.ScoreCoinP2();
        }
    }
}

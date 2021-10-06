using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float playerSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vx = Input.GetAxis("HorizontalP2");
        float vy = Input.GetAxis("VerticalP2");

        Vector3 velocity = new Vector3(vx, vy, 0) * playerSpeed;
        transform.Translate(velocity * Time.deltaTime);
    }
}

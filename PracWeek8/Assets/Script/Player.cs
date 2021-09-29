using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vx = Input.GetAxis("Horizontal");
        float vy = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(vx, vy, 0) * speed;
        transform.Translate(velocity * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
        }
    }
}

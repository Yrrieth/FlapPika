using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager.GameOver();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Jump
            rb.velocity = new Vector2(0, 4 * velocity);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}

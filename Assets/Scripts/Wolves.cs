using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class Wolves : MonoBehaviour
{
    public float speed;
    public Rigidbody2D enemyRb;
    public GameObject player;
    public float rotateSpeed = 3f;
    private float distance;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemyRb = this.GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        // distance = Vector2.Distance(transform.position, player.transform.position);
        // Vector2 direction = player.transform.position - transform.forward;
        // direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        
        Vector3 direction = player.transform.position - transform.position;
        enemyRb.MovePosition(transform.position + (direction * speed * Time.deltaTime));



        //transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { gameManager.UpdateScore(-5); }
    }
}

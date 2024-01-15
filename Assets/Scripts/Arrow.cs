using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D arrowRb;
    public float force;
    public LayerMask solidMask;
    private void Awake()
    {
        Destroy(gameObject, 2f);
    }


    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        arrowRb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        arrowRb.velocity = new Vector2 (direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rot + 90);
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Scenery")) { Destroy(this.gameObject) ; }
    //    else if (collision.gameObject.CompareTag("Player")) { }
    //    else
    //    {




    //        Destroy(collision.gameObject);
    //        Destroy(this.gameObject);
    //    }

    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) { Destroy(gameObject);Destroy(collision.gameObject); }
        
    }
}

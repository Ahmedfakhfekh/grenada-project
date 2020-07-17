using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject bullet;
    public Transform bulletTransform;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * 10;
        rb.velocity = new Vector2(x, 0);
        
        if(Input.GetKeyDown("up"))
        {
            Instantiate(bullet, bulletTransform.position, bulletTransform.rotation);
        }
    }
}

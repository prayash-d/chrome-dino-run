using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    [SerializeField] private GameObject stand;
    [SerializeField] private GameObject crouch;

    Rigidbody2D rb;
    bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false; // dino isnt jumping in the beginning
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = new Vector3(0, 20, 0);
            isJumping = true;
        }

        if (Input.GetKey(KeyCode.S) && isJumping == false)
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false; //when dino collides with ground, jumping is now false
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    private bool FacingRight = true;

    Vector2 movement;

    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        if(movement.x == -1 && FacingRight == true)
        {
            FacingRight = false;
            transform.Rotate(0,180,0);
        }
        if(movement.x == 1 && FacingRight == false)
        {
            FacingRight = true;
            transform.Rotate(0, 180, 0);
        }

        

    }

    void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            UnderWaterUI.TrashCollect += 1;
            Destroy(collision.gameObject);
        }
    }
}

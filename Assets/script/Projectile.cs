using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 4.5f;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fish")
        {
            UnderWaterUI.FishGet += 1;
            Destroy(collision.gameObject);
        }
        HarpoonScriptChange.shoot = false;
        Destroy(gameObject);
    }
}

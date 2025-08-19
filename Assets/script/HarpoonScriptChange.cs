using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonScriptChange : MonoBehaviour
{
    public Projectile HarpoonGunPre;
    public Transform Launch;
    public static bool shoot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shoot == false)
            {
                Instantiate(HarpoonGunPre, Launch.position, Launch.rotation);
                shoot = true;
            }
        }

    }
}

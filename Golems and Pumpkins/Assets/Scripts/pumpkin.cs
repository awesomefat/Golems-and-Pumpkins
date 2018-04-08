using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkin : MonoBehaviour {

    private void Update()
    {
        if(this.transform.position.y < -3f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Golem")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
        }
    }
    
}// class






















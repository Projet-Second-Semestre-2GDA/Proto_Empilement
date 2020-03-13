using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGrabMultipleObject : MonoBehaviour
{
    public GameObject him;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
   {
       if (collision.gameObject.tag == "Book")
       {
           him.GetComponent<Rigidbody>().useGravity = false;
       }
   }
}

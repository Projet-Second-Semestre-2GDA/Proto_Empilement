using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    public Transform theDest;
    // Start is called before the first frame update
    private void OnMouseDown() 
    {
        //GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    // Update is called once per frame
    private void OnMouseUp() 
    {
        this.transform.parent = null;
        //GetComponent<Rigidbody>().useGravity = true;
    }
}

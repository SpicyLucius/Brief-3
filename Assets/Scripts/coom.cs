using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) //THIS ONLY WORKS ON THE FIRST COLLISION.
{
// That parameter up there (collision) is the object that was hit and you can access it via collision.gameObject
print ("yeehaw it's ground time");

}
}

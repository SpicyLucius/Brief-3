using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) 
    {

        print ("yeow!");
    if (collision.gameObject.tag == "Wall")
        {
            print ("I hit a wall.");
            Destroy(collision.gameObject);
            print("Get fucked, wall.");
        } else {
            print ("What the hell is this?!");

        }


}
}

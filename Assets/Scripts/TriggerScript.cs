using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) //collider checks if something collides with it. Collision checks if two things smack  together.
    {
        if (other.gameObject.tag == "Player")
        {
            print ("BRUH MOMENT");
             //other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.up * 10);
             other.gameObject.GetComponent<CharacterController>().Move(new Vector3(0,1,0));
        }

        //dont forget using unityscenes scenemanager etc etc 
    }
}

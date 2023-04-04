using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
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
        if (collision.gameObject.GetComponent<LevelsOfCubeHatred>().cubeHatred > 20) {
            Destroy(gameObject);
            Debug.Log("Ouchies");
            SceneManager.LoadScene(0);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{

    public Slider hpSlider;
    public Image img;
    public GameObject player;
    [SerializeField] private Color color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHPBar(float playerHealth) {
        playerHealth = player.GetComponent<stats>().playerHealth;
        hpSlider.value = playerHealth;
        if (playerHealth <= 0) {
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            color.a = i;
            if (i >= 0.9f) {
               color.a = 1f; 
            }
            img.color = color;
            yield return null;
        }
    }
}
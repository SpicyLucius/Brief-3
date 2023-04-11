using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class HealthRemover : MonoBehaviour
{
    public Slider slider; 
    public int value; 
    private int damagePerSecond;
    public GameObject player;
    private int tHealth;
    
    void Start()
    {
        value = 100;
        damagePerSecond=1;
         if (slider != null)
        {
            slider.value = value;
        }
        else
        {
            Debug.LogWarning("Slider component not found.");
        }
    }

//ADDED
public void HealthDisplay()
{
    slider.value = player.GetComponent<stats>().playerHealth;
}


void RemoveHP()
{
    int damage = 1;
    int tHealth = player.GetComponent<stats>().playerHealth;
    tHealth -= damage;
    player.GetComponent<stats>().playerHealth = tHealth;
    HealthDisplay();
}

private void OnTriggerStay(Collider other)
{
    if (other.CompareTag("Player"))
    {
        int tempHealth = other.GetComponent<stats>().playerHealth;
        if (tempHealth > 0)
        {
            RemoveHP();
            print("Player Health: " + other.GetComponent<stats>().playerHealth);
            print("Temp Health: " + tempHealth);
        }
    }
}




   
      
}
    
   






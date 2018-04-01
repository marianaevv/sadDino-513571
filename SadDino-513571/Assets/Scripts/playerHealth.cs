using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerHealth : MonoBehaviour {
    public float fullHealth;
    public GameObject deathFx;
    float currentHealth;
    playerController controlMovement;

    //Canvas variables
    public Slider healthSlider;
 

    bool damaged= false;
 

    // Use this for initialization
    void Start() {
        currentHealth = fullHealth;
        controlMovement = GetComponent<playerController>();
        //Inicializando
       healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;
        damaged= false;
   
    }


    public void addHealth (float healthAmount)
    {
        currentHealth += healthAmount;
        if (currentHealth > fullHealth){
            currentHealth = fullHealth;
        }
            healthSlider.value = currentHealth;
       }
    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;   

        healthSlider.value = currentHealth;
        damaged= true;

        if (currentHealth <= 0)    {
            makeDead();
        }
    }
    public void makeDead(){
        Instantiate(deathFx, transform.position, transform.rotation);
        Destroy(gameObject);
        SceneManager.LoadScene("You Lose");
    }
    
}

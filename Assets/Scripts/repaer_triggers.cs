using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class repaer_triggers : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        Debug.Log(health);
            
        health -= damage;
        if(health <= 0)
        {
            Debug.Log("helth below zero");
            SceneManager.LoadScene("Scenes/WinScreen");
        }
    }
}

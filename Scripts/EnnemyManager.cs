using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnnemyManager : MonoBehaviour
{
    public GameObject ennemy, panel;
    public Transform ennemyTransform1, targ;
    int health = 100;
    public Text HealthBar;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject);
            health--;
            HealthBar.text = health.ToString();
        }
        if(collision.gameObject.name == "player")
        {
            gameover();
        }
    }
    void gameover()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    } 
    public void quit()
    {
        Application.Quit();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .005f);
        if(health == 0)
        {
            gameover();
        }
    }
}


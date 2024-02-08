using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if(GameObject.FindGameObjectWithTag("Player") != null){
            Time.timeScale = 1;
        }
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}

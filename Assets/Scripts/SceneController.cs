using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void Lose() 
    {
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}

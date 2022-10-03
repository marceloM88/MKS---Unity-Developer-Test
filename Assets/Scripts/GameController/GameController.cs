using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    float spawn;
    float time;
    public GameObject[] spawnPoints;
    public GameObject[] ships;
    public GameObject player;
    public Image afterGame;
    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameControllerMenu.spawnTime;
        time = GameControllerMenu.gameTime;   
        GameControllerMenu.spawnTime = 0;
        Spawn();
    }

    void Spawn()
    {
        GameControllerMenu.spawnTime -= Time.deltaTime;
        if (GameControllerMenu.spawnTime <= 0)
        {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                Instantiate(ships[Random.Range(0,2)], spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);
            }
            GameControllerMenu.spawnTime = spawn;
        }
        
    }
    void SessionEnd()
    {
        GameControllerMenu.gameTime -= Time.deltaTime;
        if (GameControllerMenu.gameTime <= 0)
        {
            SetPoints();
            afterGame.gameObject.SetActive(true);
            Pause();
        }

        if (player.GetComponent<PlayerStats>().life <= 0)
        {
            SetPoints();
            afterGame.gameObject.SetActive(true);
            Pause();
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
    }
    void Unpause()
    {
        Time.timeScale = 1;
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
        GameControllerMenu.gameTime = time;
        Unpause();
        GameControllerMenu.spawnTime = spawn;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    void SetPoints()
    {
        points.text = "Points: " + player.GetComponent<PlayerStats>().points.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        Spawn();
        SessionEnd();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerMenu : MonoBehaviour
{
    public static float spawnTime;
    public static float gameTime;
    public Slider gameTimeSlider;
    public Slider spawnTimeSlider;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = spawnTimeSlider.value;
        gameTime = gameTimeSlider.value;
    }
    public void ChangeValue()
    {
        spawnTime = spawnTimeSlider.value;
        gameTime = gameTimeSlider.value;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

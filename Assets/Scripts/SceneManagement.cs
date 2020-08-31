using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SceneCantina()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Cantina");
    }

    public void SceneLivingR()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("360VideoTour");
    }

    public void SceneCube()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Cube");
    }

    public void SceneMezz()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mezzanine");
    }
}

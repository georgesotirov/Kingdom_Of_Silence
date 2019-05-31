using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class MenuScript : MonoBehaviour
{

    public GameObject optionsMenu;
    public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isActive = optionsMenu.activeSelf;

            optionsMenu.SetActive(!isActive);

        }
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}


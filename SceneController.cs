using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private Scene scene;
    public void Start()
    {
     scene = SceneManager.GetActiveScene();
     
    }
    private void Update()
    {
        if (scene.name.Equals("FristScene"))
        { 
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            } 
        }
    }
    public void OnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void LoadGameScene() {
        SceneManager.LoadScene("HW3_Scene");
    }

    public void LoadEndScene(){
        SceneManager.LoadScene("End_Scene");
    }

    public void LoadStartScene() {
        SceneManager.LoadScene("Start_Scene");
    }

    public void ExitGame() {  
        Application.Quit();
    }
}

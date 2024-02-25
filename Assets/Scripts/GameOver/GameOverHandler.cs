using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}

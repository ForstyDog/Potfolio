using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager123 : MonoBehaviour
{

    public AudioSource DoorAudio;

    public void Level1Load()
    {
        SceneManager.LoadScene("Level1");
        DoorAudio.Play();
    }
    public void Level2Load()
    {
        SceneManager.LoadScene("Level2");
        DoorAudio.Play();
    }
    public void Level3Load()
    {
        SceneManager.LoadScene("Level3");
        DoorAudio.Play();
    }
    public void Level4Load()
    {
        SceneManager.LoadScene("Level4");
        DoorAudio.Play();
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Startmenu");
    }
    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("Optiesmenu");
    }
    public void Exitgame()
    {
        Application.Quit();
    }
}

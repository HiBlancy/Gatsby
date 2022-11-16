using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManagement : MonoBehaviour
{
    [SerializeField] GameObject CanvaMainMenu;
    [SerializeField] GameObject CanvaLevels;

    public void PlayPressed()
    {
        CanvaMainMenu.SetActive(false);
        CanvaLevels.SetActive(true);
    }

    public void BackToMainMenu()
    {
        CanvaMainMenu.SetActive(true);
        CanvaLevels.SetActive(false);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
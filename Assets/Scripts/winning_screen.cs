using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winning_screen : MonoBehaviour
{
    public Canvas exitMenuCanvas;
    public Button MenuButton;
    public Button exitButton;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        exitMenuCanvas.enabled = false;
    }

    public void onExitButtonClicked()
    {
        exitMenuCanvas.enabled = true;
        MenuButton.enabled = false;
        exitButton.enabled = false;
    }

    public void onNoExitConfirmButtonClicked()
    {
        exitMenuCanvas.enabled = false;
        MenuButton.enabled = true;
        exitButton.enabled = true;
    }

    public void onYesExitConfirmButtonClicked()
    {

        Application.Quit();

    }

    public void onMenuButtonClicked()
    {
        SceneManager.LoadScene("Scenes/Nightmare");
    }
}

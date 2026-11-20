using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneChangeKeyPress : MonoBehaviour
{
    private bool isLoading = false;

    void Update()
    {
        bool keyboardPressed =
            Keyboard.current != null &&
            Keyboard.current.anyKey.wasPressedThisFrame;

        bool mousePressed =
            Mouse.current != null &&
            (Mouse.current.leftButton.wasPressedThisFrame ||
             Mouse.current.rightButton.wasPressedThisFrame ||
             Mouse.current.middleButton.wasPressedThisFrame);

        if ((keyboardPressed || mousePressed) && !isLoading)
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        if (isLoading) return;

        isLoading = true;
        SceneManager.LoadSceneAsync("Game", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonController : MonoBehaviour
{
    public void ExitToMenu()
    {
        SceneManager.LoadScene("00_MenuInicio");
    }
}
using UnityEngine;

public class CambiarCamaraBoton : MonoBehaviour
{
    public GameObject thirdPersonCamera;
    public GameObject cinematicCamera;

    private bool usingThirdPerson = true;

    public void CambiarCamara()
    {
        usingThirdPerson = !usingThirdPerson;

        thirdPersonCamera.SetActive(usingThirdPerson);
        cinematicCamera.SetActive(!usingThirdPerson);
    }
}
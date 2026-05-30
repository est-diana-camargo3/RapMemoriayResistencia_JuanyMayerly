using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerBotonesDeInstrucciones : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource musicaFondo;
    public AudioSource narracion;

    void Start()
    {
        // Música de fondo
        if (musicaFondo != null)
        {
            musicaFondo.loop = true;
            musicaFondo.Play();
        }

        // Narración
        if (narracion != null)
        {
            narracion.loop = false;
            narracion.Play();
        }
    }

    public void IrAEscenario()
    {
        SceneManager.LoadScene("01_Escenario");
    }
}
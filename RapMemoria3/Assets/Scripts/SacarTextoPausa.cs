using UnityEngine;

public class SacarTextoPausa : MonoBehaviour
{
    public GameObject pausaTexto;

    private bool pausado = false;

    public void BotonPausa()
    {
        pausado = !pausado;

        if (pausado)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;

            if (pausaTexto != null)
                pausaTexto.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            AudioListener.pause = false;

            if (pausaTexto != null)
                pausaTexto.SetActive(false);
        }
    }
}
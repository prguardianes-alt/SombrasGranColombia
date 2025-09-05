using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jugar() => SceneManager.LoadScene("SeleccionRol");
    public void Opciones() => SceneManager.LoadScene("Opciones");
    public void Historia() => SceneManager.LoadScene("Historia");
    public void Creditos() => SceneManager.LoadScene("Creditos");
    public void Salir() => Application.Quit();
}

using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void GoToBasket()
    {
        SceneManager.LoadScene("Basket");
    }

    public void GoToHub()
    {
        SceneManager.LoadScene("Hub");
    }

    public void GoToLancerFranc()
    {
        SceneManager.LoadScene("LancerFranc");
    }

    public void GoToLancerPrecision()
    {
        SceneManager.LoadScene("LancerPrecision");
    }

    public void GoToMusic()
    {
        SceneManager.LoadScene("Music");
    }
}

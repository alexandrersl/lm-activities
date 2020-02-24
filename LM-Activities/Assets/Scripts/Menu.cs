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
}

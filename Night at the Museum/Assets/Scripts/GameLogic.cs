
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameLogic : MonoBehaviour
{
    private int menuActive = 0;
    public GameObject waypoints;
    public GameObject[] menus;

    private void Start()
    {
        waypoints.SetActive(false);

        for (var i = 1; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
        }
    }

    /**
     * Exibe a próxima interface (UI) com instruções.
     */
    public void NextInstruction()
    {
        menus[menuActive].SetActive(false);
        menuActive++;
        menus[menuActive].SetActive(true);
    }

    /**
     * Inicia a exploração do museu.
     */
    public void StartExploration()
    {
        waypoints.SetActive(true);
        menus[menuActive].SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMainMenuScene : MonoBehaviour
{
    public void GoBackToMain()
    {
        SceneManager.LoadScene("CityMainMenu");

    }

}

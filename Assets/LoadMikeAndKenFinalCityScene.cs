using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMikeAndKenFinalCityScene : MonoBehaviour
{
    // Start is called before the first frame update MikeAndKenCityExitScene
    void Start()
    {
        SceneManager.LoadScene("MikeAndKenCityExitScene", LoadSceneMode.Single);
    }
}

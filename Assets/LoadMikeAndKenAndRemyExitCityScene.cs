using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMikeAndKenAndRemyExitCityScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("MikeAndRemyAndKenCityExitScene", LoadSceneMode.Single);
    }
}

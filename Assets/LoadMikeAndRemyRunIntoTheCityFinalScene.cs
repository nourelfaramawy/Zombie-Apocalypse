using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMikeAndRemyRunIntoTheCityFinalScene : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {
        SceneManager.LoadScene("MikeAndRemyCityExitScene", LoadSceneMode.Single);
    }
}

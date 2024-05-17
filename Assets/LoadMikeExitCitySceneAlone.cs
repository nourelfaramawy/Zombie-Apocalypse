using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMikeExitCitySceneAlone : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {
        SceneManager.LoadScene("MikeAloneCityExitScene", LoadSceneMode.Single);
    }
}

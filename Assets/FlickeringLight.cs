using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    // Start is called before the first frame update
  
    Light flickeringLight;

    void Start()
    {
        flickeringLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.05f);
            flickeringLight.enabled = !flickeringLight.enabled;
        }
    }
}



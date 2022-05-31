using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialChange : MonoBehaviour
{
    public Material orangeLight, blueLight;
    bool orangeMaterial = true; // orangeMaterial = true(for orangeLight and orangeBGCOLOR), = false(for blueLight and blueBGCOLOR)

    public GameObject maincamera;

    private void Start() 
    {
        GetComponent<Renderer>().material = orangeLight;
        maincamera.GetComponent<Camera>().backgroundColor = new Color32(223,116,12,0);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            orangeMaterial = !orangeMaterial;
            if(orangeMaterial)
            {
                 GetComponent<Renderer>().material = orangeLight;
                 maincamera.GetComponent<Camera>().backgroundColor = new Color32(223,116,12,0);

            }
            else
            {
                 GetComponent<Renderer>().material = blueLight;
                 maincamera.GetComponent<Camera>().backgroundColor = new Color32(125,253,254,0);
            }
        }
    }
}

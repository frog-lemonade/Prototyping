using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadSetup : MonoBehaviour
{
    public static SceneLoadSetup instance;

    public DefaultControls _controlScheme;

    void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        _controlScheme = new DefaultControls();
        _controlScheme.BasicControlsP1.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

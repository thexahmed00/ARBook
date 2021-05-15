using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  Vuforia;

public class Titlebutton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text;
    private VirtualButtonBehaviour vrBehaviour;
    public AudioSource sound;
    void Start()
    {
        
        Text.SetActive(false);
       // Boy.SetActive(false);
        vrBehaviour = GetComponentInChildren<VirtualButtonBehaviour>();
        vrBehaviour.RegisterOnButtonPressed(OnButtonPressed);
        vrBehaviour.RegisterOnButtonReleased(OnButtonRelease);
        //vrBehaviour.UnregisterOnButtonPressed(OnButtonPressedOff);
    }

    // Update is called once per f
    public void OnButtonPressed(VirtualButtonBehaviour vrb)
    {
        sound.Play();
        Text.SetActive(true);
       // Boy.SetActive(true);
       Debug.Log("button click");
    }
    public void OnButtonRelease(VirtualButtonBehaviour vrb)
    {
        sound.Stop();
        Text.SetActive(false);
        // Boy.SetActive(true);
    }

}

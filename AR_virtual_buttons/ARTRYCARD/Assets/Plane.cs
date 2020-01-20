using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Plane : MonoBehaviour, IVirtualButtonEventHandler
{
   public GameObject plane1, plane3;
    // Start is called before the first frame update
 

    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
   
       
        for (int i= 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);

        }
        plane1.SetActive(false);
        
        plane3.SetActive(false);
        



        
    }
   
   
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "vb1")
        {
            Debug.Log("VB1");
            plane1.SetActive(true);
            plane3.SetActive(false);
           
          
        }
       
       else if (vb.VirtualButtonName == "vb3")
        {
            Debug.Log("VB3");
            plane3.SetActive(true);
            plane1.SetActive(false);
           
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual button not supported");
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
        
    }
}

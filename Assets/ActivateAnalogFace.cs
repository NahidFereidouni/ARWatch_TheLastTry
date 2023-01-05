using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class ActivateAnalogFace : MonoBehaviour
{
    public GameObject ARWatch;
    public GameObject AnalogClockFace;
    public GameObject DigitalClockFace;
    RaycastHit hit;
    public bool swapAnalog;
    //public bool swapDigital;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AnalogClockFace.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            AnalogClockFace.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            FireScreenRay();
        }
    }

    void FireScreenRay()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(cameraRay, out RaycastHit hit))
        {
            if (hit.collider.gameObject.name == "ARWatch")
            {
                AnalogClockFace.SetActive(swapAnalog);
                //DigitalClockFace.SetActive(swapDigital);

                if (swapAnalog == false)
                {
                    swapAnalog = true;
                    //swapDigital = false;
                }
                else
                {
                    swapAnalog = false;
                    //swapDigital = true;
                }

            }
        }
    }
}

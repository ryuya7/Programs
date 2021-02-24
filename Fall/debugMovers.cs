using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class debugMovers : MonoBehaviour
{
    [SerializeField]
    Transform Head = null;
    const float Angle = 0.01f;
    const float DashSpeed = 5f;
    const float SlowSpeed = 0.2f;

    void Reset(){
        Head = GetComponentInChildren<OVRCameraRig>().transform.Find("TrackingSpace/CenterEyeAnchor");
    }

    float Scale{
        get{
            return IsPressTrigger ? DashSpeed : IsPressGrip ? SlowSpeed : 1f;
        }
    }

    bool IsPressTrigger{
        get{
            return OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger);            
        }
    }

    bool IsPressGrip{
        get{
            return OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger);
        }
    }

    void Update(){
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp)){
            var forward = Head.forward;
            forward.y = 0;
            transform.position += forward.normalized * Time.deltaTime * Scale;
        }
        if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown)){
            var forward = Head.forward;
            forward.y = 0;
            transform.position -= forward.normalized * Time.deltaTime * Scale;
        }
        if(OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickLeft) || OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickLeft)){
            transform.Rotate(0, -Angle, 0);
        }
        if(OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickRight) || OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickRight)){
            transform.Rotate(0, Angle, 0);
        }
        if(OVRInput.GetDown(OVRInput.Button.Four) || OVRInput.GetDown(OVRInput.Button.Two)){
            transform.position += Vector3.up * Scale;
        }
        if(OVRInput.GetDown(OVRInput.Button.Three) || OVRInput.GetDown(OVRInput.Button.One)){
            transform.position -= Vector3.up * Scale;
        }
        if(OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)){
            SceneManager.LoadScene("SampleScene");
        }
    }
}

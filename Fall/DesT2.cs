using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesT2 : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit){
        if(hit.gameObject.tag == "tower2"){
            GameObject tower2 = GameObject.Find("tower2");
            tower2.GetComponent<Renderer>().material.color = Color.clear;
            Destroy(tower2, 2.0f);
        }
    }
}

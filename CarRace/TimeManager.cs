using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private float currentTime = 0.000f;
    private static float fastestTime = 999.999f;
    public Text currentTimeText;
    public Text fastestTimeText;
    public Text startText;
    private bool isStart = false;
    public Rigidbody CarRigidbody;

    void Start(){
        startText.text = "";
        fastestTimeText.text = "Fastest : " + fastestTime.ToString("0.000");
        currentTimeText.text = "Time : " + currentTime.ToString("0.000");

        StartCoroutine(StartTimer());
    }

    void Update(){
        if(isStart){
            currentTime += Time.deltaTime;
            currentTimeText.text = "Time : " + currentTime.ToString("0.000");
        }
    }

    IEnumerator StartTimer(){
        startText.text = "3";
        yield return new WaitForSeconds(1.0f);
        startText.text = "2";
        yield return new WaitForSeconds(1.0f);
        startText.text = "1";
        yield return new WaitForSeconds(1.0f);
        startText.text = "GO!!";
        isStart = true;
        CarRigidbody.constraints = RigidbodyConstraints.None;
        CarRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        yield return new WaitForSeconds(0.5f);
        startText.text = "";
    }

    public void UpdateFastestTime(){
        if(currentTime < fastestTime){
            fastestTime = currentTime;
        }
    }
}

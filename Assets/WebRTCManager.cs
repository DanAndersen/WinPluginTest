using System.Collections;
using System.Collections.Generic;
using WSAUnity;
using UnityEngine;

public class WebRTCManager : MonoBehaviour
{

    private Plugin p;

    // Use this for initialization
    void Start()
    {
        //Messenger.AddListener<string>(SympleLog.LogTrace, OnLog);
        Messenger.AddListener<string>(SympleLog.LogDebug, OnLog);
        Messenger.AddListener<string>(SympleLog.LogInfo, OnLog);
        Messenger.AddListener<string>(SympleLog.LogError, OnLog);

        p = new Plugin();


    }

    public void OnTestWebRTCInitButtonPressed()
    {
        OnLog("starting test init of WebRTC...");
        p.initAndStartWebRTC();
        OnLog("done with test init of WebRTC");
    }

    void OnLog(string msg)
    {
        DebugText.Instance.AddMessage(msg);
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

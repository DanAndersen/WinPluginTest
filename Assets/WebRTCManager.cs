using System.Collections;
using System.Collections.Generic;
using WSAUnity;
using UnityEngine;

public class WebRTCManager : MonoBehaviour
{

    private StarWebrtcContext starWebrtcContext;
    
    // Use this for initialization
    void Start()
    {
        starWebrtcContext = StarWebrtcContext.CreateTraineeContext();
        // right after creating the context (before starting the connections), we could edit some parameters such as the signalling server

        //Messenger.AddListener<string>(SympleLog.LogTrace, OnLog);
        Messenger.AddListener<string>(SympleLog.LogDebug, OnLog);
        Messenger.AddListener<string>(SympleLog.LogInfo, OnLog);
        Messenger.AddListener<string>(SympleLog.LogError, OnLog);
        
    }

    public void OnTestWebRTCInitButtonPressed()
    {
        OnLog("starting test init of WebRTC...");
        starWebrtcContext.initAndStartWebRTC();
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

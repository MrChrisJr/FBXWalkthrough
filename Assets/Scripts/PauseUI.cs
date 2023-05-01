using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{
    bool isJustStarted = true;

    private void OnEnable()
    {
        EventManager.StartListening(EventManager.Events.Pause, UpdatePause);
    }

    private void OnDisable()
    {
        EventManager.StopListening(EventManager.Events.Pause, UpdatePause);
    }

    void UpdatePause(GameObject go)
    {
        bool isEnabled = go.GetComponent<AppPaused>().isPaused;

        if(isJustStarted)
        {
            isEnabled = false;
            isJustStarted = false;
        }

        transform.GetChild(0).gameObject.SetActive(isEnabled);
    }
}

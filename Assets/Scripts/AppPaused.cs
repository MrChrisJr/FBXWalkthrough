using UnityEngine;
using UnityEngine.UIElements;

public class AppPaused : MonoBehaviour
{
    public bool isPaused = false;
    public bool lastIsPaused = true;

    void OnGUI()
    {
        if (isPaused != lastIsPaused)
        {
            EventManager.TriggerEvent(EventManager.Events.Pause, gameObject);
        }
        lastIsPaused = isPaused;
    }

    private void Start()
    {
        isPaused = true;
        lastIsPaused = true;

        EventManager.TriggerEvent(EventManager.Events.Pause, gameObject);
    }

    private void Update()
    {
        /*if(isPaused == true)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
                isPaused = false;
        }
        if (isPaused == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                isPaused = true;
        }*/
        
         if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;
    }

    void OnApplicationFocus(bool hasFocus)
    {
        isPaused = !hasFocus;
    }

    void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
    }
}

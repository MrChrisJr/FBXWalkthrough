using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToClose : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            gameObject.SetActive(false);
    }
}

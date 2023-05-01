using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToUnload : MonoBehaviour
{
    public GameObject map1;
    public GameObject map2;
    public GameObject player;
    bool mapPhase;

    // Start is called before the first frame update
    void Start()
    {
        mapPhase = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        loadMaps(mapPhase);
        //player.GetComponentInParent<>
        //player.AddForce(Vector3.up, (ForceMode)500);
    }

    private void loadMaps(bool mapPhase)
    {
        mapPhase = !mapPhase;
        map1.SetActive(mapPhase);
        map2.SetActive(!mapPhase);
    }
}

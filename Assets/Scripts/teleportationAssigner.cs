using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

namespace UnityEngine.XR.Interaction.Toolkit
{
public class teleportationAssigner : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return null;
        yield return null;
        foreach(TeleportationArea ta in GameObject.FindObjectsOfType<TeleportationArea>())
        {
            ta.teleportationProvider = GetComponent<TeleportationProvider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}

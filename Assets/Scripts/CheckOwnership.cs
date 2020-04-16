using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit;
namespace UnityEngine.SpatialTracking{
public class CheckOwnership : MonoBehaviour
{

    public RealtimeView realtime;
    public Camera playerCam;
    public TrackedPoseDriver[] tpds;
    // Start is called before the first frame update
    void Start()
    {

        if(!realtime.isOwnedLocally){
            GetComponentInChildren<Camera>().enabled = false;
            GetComponent<teleportationAssigner>().enabled = false;
            GetComponent<TeleportationProvider>().enabled = false;
            GetComponent<LocomotionSystem>().enabled = false;;

            foreach(TrackedPoseDriver tpd in GetComponentsInChildren<TrackedPoseDriver>())
            {
                tpd.enabled = false;
            }
            foreach(XRController xrc in GetComponentsInChildren<XRController>())
            {
                xrc.enabled = false;
            }
            foreach(XRRayInteractor xrc in GetComponentsInChildren<XRRayInteractor>())
            {
                xrc.enabled = false;
            }
        }else{
            GetComponent<teleportationAssigner>().enabled = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
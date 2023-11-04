using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Start is called before the first frame update
   public void SwitchCamera(int CameraId)
    {
        foreach(int Key in Controller.Cameras.Keys)
        {
            if(CameraId == Key)
            {
                Controller.Cameras[CameraId].GetComponent<Camera>().enabled = true;
            }
            else
            {
                Controller.Cameras[Key].GetComponent<Camera>().enabled = false;
            }
        }
    }

    public void CameraFollowing(GameObject Player, int CameraId)
    {
        Controller.Cameras[CameraId].transform.position = Player.transform.position + new Vector3(0,0,5);
    }
}

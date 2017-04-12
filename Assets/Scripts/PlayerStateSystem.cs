﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStateSystem : MonoBehaviour
{
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "Heights" && transform.position.y <= -200)
        {
            Events.PlayerDeath.Invoke();
            return;
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            Events.PlayerDeath.Invoke();
            return;
        }

        if (OVRInput.GetDown(OVRInput.Button.Four) || Input.GetKeyDown("f"))
        {
            Events.PlayerForceScene.Invoke();
            return;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            Events.RoomCompleted.Invoke();
        }
    }
}

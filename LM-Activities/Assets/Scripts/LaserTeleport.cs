using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;


public class LaserTeleport : MonoBehaviour
{
    Controller controller;
    private LineRenderer laser;
    void Start()
    {
        laser = GetComponent<LineRenderer>();
        controller = new Controller();
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = controller.Frame(); // controller is a Controller object
        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;
            Hand leftHand = null;
            Hand rightHand = null;
            if (hands.Count == 2)
            {
                if (hands[0].IsLeft)
                {
                    leftHand = hands[0];
                    rightHand = hands[1];
                }
                else
                {
                    leftHand = hands[1];
                    rightHand = hands[0];
                }
                afficherLaser(rightHand.Finger(1));
                if (leftHand.GrabStrength > 0.99)
                {
                    teleport();
                }
            }   
        }
    }
    public void teleport()
    {
        GameObject mainCamera = GameObject.Find("Leap Rig");
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                laser.SetPosition(1, hit.point);
                Vector3 pos = mainCamera.transform.position;
                mainCamera.transform.position = hit.point;
            }
        }
        else
        {
            laser.SetPosition(1, transform.position + (transform.forward * 5000));
        }
    }
    public void afficherLaser(Finger finger)
    {
        Vector3 posFinger = new Vector3(finger.TipPosition.x, finger.TipPosition.y, finger.TipPosition.z);
        laser.transform.position = posFinger;
        laser.SetPosition(0, posFinger);
    }
}


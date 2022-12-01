using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform player;
    public Transform startLoc;
    public Transform Kitchen;
    public Transform Bathroom;
    public Transform Bedroom;
    public Transform Lounge;
    public Transform Fireplace;
    public Transform Sea;
    public Transform Doors;

    public void TeleStart()
    {
        player.transform.position = startLoc.transform.position;
    }

    public void TeleLoc1()
    {
        player.transform.position = Kitchen.transform.position;
    }

    public void TeleLoc2()
    {
        player.transform.position = Bathroom.transform.position;
    }

    public void TeleLoc3()
    {
        player.transform.position = Bedroom.transform.position;
    }

    public void TeleLoc4()
    {
        player.transform.position = Lounge.transform.position;
    }


    public void TeleLoc5()
    {
        player.transform.position = Fireplace.transform.position;
    }

    public void TeleLoc6()
    {
        player.transform.position = Sea.transform.position;
    }

    public void TeleLoc7()
    {
        player.transform.position = Doors.transform.position;
    }
}

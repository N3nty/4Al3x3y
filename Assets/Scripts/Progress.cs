using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static int lvl = 0;

    public void SetLevel(int newLvl)
    {
        lvl = newLvl;
    }
}

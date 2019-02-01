using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public static int money = 0;
    public static int life = 10;

    void OnGUI()
    {
        if (life != 0)
        {
            GUI.Box(new Rect(40, 40, 150, 40), "Bonus money = " + money);
        }
        else
        {
            GUI.Box(new Rect(40, 40, 150, 40), "Death");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starpick : MonoBehaviour
{
    string star;

void Start()
{
    Phase1();
    Phase2();
    Phase3();
    Phase4();
    Phase5();
}

public void Phase1()
{
    star = string.Empty;

        for (int i = 0; i < 15; i++)
        {

            star += "★";
            if (i == 0)
            {
                star += "\n";
            }
            else if (i == 2)
            {
                star += "\n";
            }
            else if (i == 5)
            {
                star += "\n";
            }
            else if (i == 9)
            {
                star += "\n";
            }
            
        }


    Debug.Log(star);
}

public void Phase2()
{
    star = string.Empty;

        // 페이즈 2
        for (int i = 0; i < 15; i++)
        {

            star += "     ";
            if (i == 3)
            {
                star += "★";
                star += "\n";
            }
            else if (i == 6)
            {
                star += "★";
                star += "★";
                star += "\n";
            }
            else if (i == 8)
            {
                star += "★";
                star += "★";
                star += "★";
                star += "\n";
            }
            else if (i == 9)
            {
                star += "★";
                star += "★";
                star += "★";
                star += "★";
                star += "\n";
                star += "★";
                star += "★";
                star += "★";
                star += "★";
                star += "★";
            }
            
            
        }

    Debug.Log(star);
}

public void Phase3()
{
    star = string.Empty;

    // 페이즈 3


    Debug.Log(star);
}

public void Phase4()
{
    star = string.Empty;

    // 페이즈 4


    Debug.Log(star);
}

public void Phase5()
{
    star = string.Empty;

    // 페이즈 5


    Debug.Log(star);
}
}

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace GETTINGOVERITHack
{
    public class CManager
    {
        //SYSTEM MODS
        public static LB_Menu lib_Menu;

        //HACK MODS
        public static H_Main hk_Main;
        public static H_Player hk_Player;

        public static void injHacks(GameObject go)
        {
            hk_Main = go.AddComponent<H_Main>();
            hk_Player = go.AddComponent<H_Player>();
        }

        public static void injSystem(GameObject go)
        {
            lib_Menu = go.AddComponent<LB_Menu>();
        }
    }
}
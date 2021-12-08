using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GETTINGOVERITHack
{
    public class H_Main : Menu
    {

        public H_Main() : base(new Rect(10, 10, 200, 100), "Sympa la LP Prog", 0, true) { }


        public override void runWin(int id)
        {
            if (GUILayout.Button("Player"))
            {
                CManager.hk_Player.isOpen = !CManager.hk_Player.isOpen;
            }
            GUILayout.Label("Ceci n'est pas un modMenu");
            base.runWin(id);
        }
    }
}
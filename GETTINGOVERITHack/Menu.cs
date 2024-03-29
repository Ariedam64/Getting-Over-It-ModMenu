﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GETTINGOVERITHack
{
    public class Menu : MonoBehaviour
    {
        public bool isOpen;
        public string title;
        public Rect window;
        public int wID;

        public Menu(Rect window, string title, int wID, bool isOpen)
        {
            this.isOpen = isOpen;
            this.title = title;
            this.window = window;
            this.wID = wID;
        }

        public virtual void runWin(int id)
        {
            if (id != 0)
            {
                if (GUILayout.Button("Exit"))
                {
                    isOpen = false;
                }
            }

            GUI.DragWindow();
        }
    }
}

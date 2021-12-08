using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Reflection;
using System;
using System.Runtime.InteropServices;
using FluffyUnderware.Curvy.Examples;
using System.Threading;

namespace GETTINGOVERITHack
{
    public class H_Player : Menu
    {
        private float gravity = -10f;
        private float prevGravity;

        private bool followCursor = false;

        public H_Player() : base(new Rect(220, 10, 200, 200), "Player Menu", 1, false) { }

        public void Update()
        {
            if (gravity != prevGravity)
            {
                Physics2D.gravity = new Vector2(0f, gravity);
                prevGravity = gravity;
            }
            if (followCursor)
            {
                FindObjectOfType<Teleporter>().player.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        public override void runWin(int id)
        {
            GUILayout.Label("Gravity: " + gravity);
            gravity = (int)Math.Round(GUILayout.HorizontalSlider(gravity, -20, 20), 1);
            if (GUILayout.Button("Teleport to end"))
            {
                FindObjectOfType<Teleporter>().player.transform.position = new Vector2(85f, 450f);
            }
            followCursor = GUILayout.Toggle(followCursor, "Follow cursor");
            base.runWin(id);
        }
    }
}
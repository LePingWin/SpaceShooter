using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

public class Hazard : MonoBehaviour
    {
        private Controls player;
        public Transform start;

        void Start()
        {
            player = FindObjectOfType<Controls>();
        }

        void Update()
        {
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                player.transform.position = start.position;
            }
        }
    }
}

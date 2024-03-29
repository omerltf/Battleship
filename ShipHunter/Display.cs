﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHunter {
    enum ColorCode {
        Blue,
        Gray,
        Red,
    }

    class Display {
        public bool hit {
            get; set;
        }
        public bool isShipHere {
            get; set;
        }

        public ShipType shipType;

        public Display(bool isHit, bool _isShipHere, ShipType ShipType) {
            this.hit = isHit;
            this.isShipHere = _isShipHere;
            this.shipType = ShipType;
            UpdateDisplay();
        }

        public void UpdateDisplay() {
            if (this.hit == false) {
                UpdateColor(ConsoleColor.Blue);
            }
            else {
                if (this.isShipHere == false) {
                    //display gray
                    UpdateColor(ConsoleColor.Gray);
                }
                else {
                    //display red
                    UpdateColor(ConsoleColor.Red);
                }
            }
        }

        public void UpdateColor (ConsoleColor color) {
            ConsoleColor backgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.Write("  ");
            Console.BackgroundColor = backgroundColor;
        }
    }
}

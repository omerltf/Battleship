using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHunter {
    public enum ShipType {
        carrier,
        battleship,
        cruiser,
        destroyerOne,
        destroyerTwo,
        submarineOne,
        submarineTwo,
        none
    }

    class Ships {
        public int shipLength {
            get; private set;
        }
        public bool stillAlive {
            get; private set;
        }
        public int shipHealth {
            get; set;
        }
        public ShipType ShipType {
            get; private set;
        }

        
        public Ships(ShipType shipTypeInherited) {
            ShipType = shipTypeInherited;
            InitShips(ShipType);
        }
        private void InitShips(ShipType shipTypeInherited) {
            switch (shipTypeInherited) {
                case ShipType.carrier:
                    shipLength = 5;
                    shipHealth = shipLength;
                    break;
                case ShipType.battleship:
                    shipLength = 4;
                    shipHealth = shipLength;
                    break;
                case ShipType.cruiser:
                    shipLength = 3;
                    shipHealth = shipLength;
                    break;
                case ShipType.destroyerOne:
                    shipLength = 2;
                    shipHealth = shipLength;
                    break;
                case ShipType.destroyerTwo:
                    shipLength = 2;
                    shipHealth = shipLength;
                    break;
                case ShipType.submarineOne:
                    shipLength = 1;
                    shipHealth = shipLength;
                    break;
                case ShipType.submarineTwo:
                    shipLength = 1;
                    shipHealth = shipLength;
                    break;
            }
        }
    }
}

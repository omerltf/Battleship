using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHunter {
    public enum Direction {
        UP,
        DOWN,
        RIGHT,
        LEFT
    }

    class Program {

        static Display[,] gameDisplay = new Display [10,10];
        static List<Ships> ships = new List<Ships>();
        static int totalShips = 7;
        static int totalTries = 25;

        public static void initDisplay () {
            Console.Write("   1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine();
            char ch = 'A';
            for (int r=0; r<10; r++) {
                Console.ResetColor();
                Console.Write(ch);
                Console.Write("  ");
                for (int c=0; c<10; c++) {
                    gameDisplay[r, c] = new Display(false, false, ShipType.none);
                }
                ch++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void initialize() {
            Ships carrier = new Ships(ShipType.carrier);
            Ships battleShip = new Ships(ShipType.battleship);
            Ships cruiser = new Ships(ShipType.cruiser);
            Ships destroyerOne = new Ships(ShipType.destroyerOne);
            Ships destroyerTwo = new Ships(ShipType.destroyerTwo);
            Ships subOne = new Ships(ShipType.submarineOne);
            Ships subTwo = new Ships(ShipType.submarineTwo);
            ships.Add(carrier);
            ships.Add(battleShip);
            ships.Add(cruiser);
            ships.Add(destroyerOne);
            ships.Add(destroyerTwo);
            ships.Add(subOne);
            ships.Add(subTwo);

            PlaceShips(ships);
        }

        public static bool? PlaceOnDisplay (int cols, int rows, Direction primaryDirection, Direction secondaryDirection, Ships ship) {
            bool? successful = null;
            
            switch (primaryDirection) {
                case Direction.UP:
                    int rowUp = rows;
                    for (int count=0; count<ship.shipLength; count++) {
                        if (gameDisplay[rowUp, cols].isShipHere) {
                            successful = false;
                            break;
                        }
                        rowUp -= 1;
                    }
                    if (successful == null) {
                        successful = true;
                    }
                    if (successful==true) {
                        rowUp = rows;
                        for (int count = 0; count < ship.shipLength; count++) {
                            gameDisplay[rowUp, cols].isShipHere = true;
                            gameDisplay[rowUp, cols].shipType = ship.ShipType;
                            rowUp -= 1;
                        }
                        return successful;
                    }
                    break;

                case Direction.DOWN:
                    int rowDown = rows;
                    for (int count = 0; count < ship.shipLength; count++) {
                        if (gameDisplay[rowDown, cols].isShipHere) {
                            successful = false;
                            break;
                        }
                        rowDown += 1;
                    }
                    if (successful == null) {
                        successful = true;
                    }
                    if (successful == true) {
                        rowDown = rows;
                        for (int count = 0; count < ship.shipLength; count++) {
                            gameDisplay[rowDown, cols].isShipHere = true;
                            gameDisplay[rowDown, cols].shipType = ship.ShipType;
                            rowDown += 1;
                        }
                        return successful;
                    }
                    break;

                case Direction.RIGHT:
                    int colRight = cols;
                    for (int count = 0; count < ship.shipLength; count++) {
                        if (gameDisplay[rows, colRight].isShipHere) {
                            successful = false;
                            break;
                        }
                        colRight += 1;
                    }
                    if (successful == null) {
                        successful = true;
                    }
                    if (successful == true) {
                        colRight = cols;
                        for (int count = 0; count < ship.shipLength; count++) {
                            gameDisplay[rows, colRight].isShipHere = true;
                            gameDisplay[rows, colRight].shipType = ship.ShipType;
                            colRight += 1;
                        }
                        return successful;
                    }
                    break;

                case Direction.LEFT:
                    int colLeft = cols;
                    for (int count = 0; count < ship.shipLength; count++) {
                        if (gameDisplay[rows, colLeft].isShipHere) {
                            successful = false;
                            break;
                        }
                        colLeft -= 1;
                    }
                    if (successful == null) {
                        successful = true;
                    }
                    if (successful == true) {
                        colLeft = cols;
                        for (int count = 0; count < ship.shipLength; count++) {
                            gameDisplay[rows, colLeft].isShipHere = true;
                            gameDisplay[rows, colLeft].shipType = ship.ShipType;

                            colLeft -= 1;
                        }
                        return successful;
                    }
                    break;
            } 

            if (successful == false) {
                switch (secondaryDirection) {
                    case Direction.UP:
                        int rowUp = rows;
                        for (int count = 0; count < ship.shipLength; count++) {
                            if (gameDisplay[rowUp, cols].isShipHere) {
                                successful = false;
                                break;
                            }
                            rowUp -= 1;
                        }
                        if (successful == null) {
                            successful = true;
                        }
                        if (successful == true) {
                            rowUp = rows;
                            for (int count = 0; count < ship.shipLength; count++) {
                                gameDisplay[rowUp, cols].isShipHere = true;
                                gameDisplay[rowUp, cols].shipType=ship.ShipType;
                                rowUp -= 1;
                            }
                            return successful;
                        }
                        break;

                    case Direction.DOWN:
                        int rowDown = rows;
                        for (int count = 0; count < ship.shipLength; count++) {
                            if (gameDisplay[rowDown, cols].isShipHere) {
                                successful = false;
                                break;
                            }
                            rowDown += 1;
                        }
                        if (successful == null) {
                            successful = true;
                        }
                        if (successful == true) {
                            rowDown = rows;
                            for (int count = 0; count < ship.shipLength; count++) {
                                gameDisplay[rowDown, cols].isShipHere = true;
                                gameDisplay[rowDown, cols].shipType = ship.ShipType;
                                rowDown += 1;
                            }
                            return successful;
                        }
                        break;

                    case Direction.RIGHT:
                        int colRight = cols;
                        for (int count = 0; count < ship.shipLength; count++) {
                            if (gameDisplay[rows, colRight].isShipHere) {
                                successful = false;
                                break;
                            }
                            colRight += 1;
                        }
                        if (successful == null) {
                            successful = true;
                        }
                        if (successful == true) {
                            colRight = cols;
                            for (int count = 0; count < ship.shipLength; count++) {
                                gameDisplay[rows, colRight].isShipHere = true;
                                gameDisplay[rows, colRight].shipType = ship.ShipType;
                                colRight += 1;
                            }
                            return successful;
                        }
                        break;

                    case Direction.LEFT:
                        int colLeft = cols;
                        for (int count = 0; count < ship.shipLength; count++) {
                            if (gameDisplay[rows, colLeft].isShipHere) {
                                successful = false;
                                break;
                            }
                            colLeft -= 1;
                        }
                        if (successful == null) {
                            successful = true;
                        }
                        if (successful == true) {
                            colLeft = cols;
                            for (int count = 0; count < ship.shipLength; count++) {
                                gameDisplay[rows, colLeft].isShipHere = true;
                                gameDisplay[rows, colLeft].shipType = ship.ShipType;
                                colLeft -= 1;
                            }
                            return successful;
                        }
                        break;
                }
            }
            return successful=false;
        }

        public static bool? GetPlacementLogic (int rows, int cols, Ships ship) {
            if (rows + ship.shipLength > 9) {             //can't go down
                if (cols + ship.shipLength > 9) {         //can't go right
                                                          //can go up or left // making judgement call for now
                    if (PlaceOnDisplay(cols, rows, Direction.UP, Direction.LEFT, ship) == true) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }

                if (cols - ship.shipLength < 0) {         //can't go left
                                                          //can go up or right
                    if (PlaceOnDisplay(cols, rows, Direction.RIGHT, Direction.UP, ship) == true) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            else {                          //can go down
                if (cols + ship.shipLength > 10) {        //can't go right
                                                          //can go down or left
                    if (PlaceOnDisplay(cols, rows, Direction.LEFT, Direction.DOWN, ship) == true) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }

                if (cols - ship.shipLength < 0) {         //can't go left
                                                          //can go down or right
                    if (PlaceOnDisplay(cols, rows, Direction.DOWN, Direction.RIGHT, ship) == true) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            return null;
        }


        public static void PlaceShips (List<Ships> ships) {
            Random random = new Random();
            int rows;
            int cols;

            for (int count=0; count<ships.Count; count++) {
                Ships ship = ships[count];
                while (true) {
                    rows = random.Next(10);
                    cols = random.Next(10);
                    bool? result = GetPlacementLogic(rows, cols, ship);
                    if (result == true) {
                        UpdateDisplay();
                        break;
                    }
                    if (result == false || result == null) {
                        continue;
                    }
                }
            }
            GetUserInput();
        }

        public static void UpdateDisplay() {
            Console.Clear();
            Console.Write("   1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine();
            char ch = 'A';
            for (int r = 0; r < 10; r++) {
                Console.ResetColor();
                Console.Write(ch);
                Console.Write("  ");
                for (int c = 0; c < 10; c++) {
                    gameDisplay[r, c].UpdateDisplay();
                }
                ch++;
                Console.WriteLine();
            }
        }

        public static void GetUserInput() {
            while (true) {
                Console.WriteLine("There are {0} ships left.", totalShips);
                Console.WriteLine("You have {0} tries left.", totalTries);
                Console.Write("Fire at: (C3 or A10)");
                string input = Console.ReadLine();
                Console.WriteLine();
                char[] inputArray=input.ToCharArray();
                if (inputArray.Length <= 1) {
                    Console.WriteLine("Incorrect input. Please try again");
                    continue;
                }
                if (!(inputArray[0]>='A' && inputArray[0] <= 'J')) {
                    Console.WriteLine("Incorrect input. Please try again");
                    continue;
                }

                if (!(inputArray[1] >= '1' && inputArray[1] <= '9')) {
                    Console.WriteLine("Incorrect input. Please try again");
                    continue;
                }

                if ((inputArray.Length == 3) && (inputArray[2] != '0')) {
                    Console.WriteLine("Incorrect input. Please try again");
                    continue;
                }

                GameLogic(inputArray);
            }
        }

        public static void GameLogic (char[] userInput) {
            int rows = 0;
            int cols;
            int testChar = 'A';
            while (testChar != userInput[0]) {
                testChar++;
                rows++;
            }
            if (userInput.Length == 3) {
                cols = 9;
            }
            else {
                cols = userInput[1] - '1';
            }
            FireAway(rows, cols);
        }

        public static void FireAway(int rows, int cols) {
            gameDisplay[rows, cols].hit = true;
            if (gameDisplay[rows, cols].isShipHere) {               //if I hit a ship
                switch (gameDisplay[rows, cols].shipType) {
                    case ShipType.battleship:
                        Ships battleShip = ships[1];
                        battleShip.shipHealth -= 1;
                        if (battleShip.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Battleship was destroyed");
                            totalShips -= 1;
                            Console.ReadKey();
                        }
                        ships[1] = battleShip;
                        break;
                    case ShipType.carrier:
                        Ships carrier = ships[0];
                        carrier.shipHealth -= 1;
                        if (carrier.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Carrier was destroyed");
                            totalShips -= 1;
                            Console.ReadKey();
                        }
                        ships[0] = carrier;
                        break;
                    case ShipType.cruiser:
                        Ships cruiser = ships[2];
                        cruiser.shipHealth -= 1;
                        if (cruiser.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Cruiser was destroyed");
                            totalShips -= 1;
                            Console.ReadKey();
                        }
                        ships[2] = cruiser;
                        break;
                    case ShipType.destroyerOne:
                        Ships destroyer_1 = ships[3];
                        destroyer_1.shipHealth -= 1;
                        if (destroyer_1.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Destroyer 1 was destroyed");
                            totalShips -= 1;
                            Console.ReadKey();
                        }
                        ships[3] = destroyer_1;
                        break;
                    case ShipType.destroyerTwo:
                        Ships destroyer_2 = ships[4];
                        destroyer_2.shipHealth -= 1;
                        if (destroyer_2.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Destroyer 2 was destroyed");
                            totalShips -= 1;
                            Console.ReadKey();
                        }
                        ships[4] = destroyer_2;
                        break;
                    case ShipType.submarineOne:
                        Ships sub_1 = ships[5];
                        sub_1.shipHealth -= 1;
                        if (sub_1.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Submarine 1 was destroyed");
                            totalShips -= 1;
                            Console.ReadKey();
                        }
                        ships[5] = sub_1;
                        break;
                    case ShipType.submarineTwo:
                        Ships sub_2 = ships[6];
                        sub_2.shipHealth -= 1;
                        if (sub_2.shipHealth == 0) {
                            UpdateDisplay();
                            Console.WriteLine("Submarine 2 was destroyed");
                            totalShips -= 1;
                            Console.WriteLine("There are {0} ships left.", totalShips);
                            Console.ReadKey();
                        }
                        ships[6] = sub_2;
                        break;
                }
                if (totalShips == 0) {
                    Console.WriteLine("You are too good, I humbly accept defeat.");
                    Console.ReadKey();
                }
            }
            else {
                totalTries -= 1;
                UpdateDisplay();
                Console.WriteLine("You missed. You have {0} tries left.", totalTries);
                if (totalTries == 0) {
                    Console.WriteLine("You ran out of tries. You lose.");
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
            UpdateDisplay();
        }

        static void Main(string[] args) {
            initDisplay();
            initialize();
        }
    }
}

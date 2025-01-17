// See https://aka.ms/new-console-template for more information


int[,] shadingPattern = new int[Console.WindowHeight, Console.WindowWidth];
// b moves x, a moves y in reverse
int a = 0;
int b = 0;

while (b <= 20)
{
    Console.Clear();

    //Assign Clock Face values to multi dimensional matrix using a method
    shadingPattern = assignClockFace(shadingPattern, a, b);

    //Center
    shadingPattern[9 + a, 9 + b] = 1;

    Console.ResetColor();
    // Console.Write("What is the width of the clock hand? ");
    // double width = Convert.ToDouble(Console.ReadLine());
    double width = 1;

    Console.Write("What hour is it? ");
    int hour = Convert.ToInt32(Console.ReadLine());

    //convert hour to theta
    double theta = 90 - (30 * hour);

    // Console.Write("What is the length of the clock hand? (7 or less) ");
    // double length = Convert.ToDouble(Console.ReadLine());
    double length = 7;


    // Normalize theta to be within [0, 360)
    theta = theta % 360;
    if (theta < 0)
        {
        theta += 360;
        }

    Console.Clear(); //Clear the screen to apply colors

    //Assign Clock Hand values to multi dimensional matrix using a method
    shadingPattern = assignClockHand(shadingPattern, width, theta, length, a, b);

    //runs the shading loop
    for (int i = 0; i < Console.WindowHeight; i++)
    {
        for (int j = 0; j <= Console.WindowWidth / 2 - 1; j++)
        {
            if (shadingPattern[i, j] == 0)
            {
                //Sets color of non-shaded cells to blue
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(" .");
            }
            else
            {
                //Sets color of shaded cells to Magenta
                // Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  ");
            }
        }
        if (i != Console.WindowHeight - 1)
        {
            Console.WriteLine("");
        }
    }

    Thread.Sleep(1000);

    //resets all array nums to zero
    int rowNum = shadingPattern.GetLength(0);
    int colNum = shadingPattern.GetLength(1);

    foreach (int r in Enumerable.Range(0, rowNum))
    {
        foreach (int c in Enumerable.Range(0, colNum))
        {
            shadingPattern[r, c] = 0;
        }
    }
    Console.Clear();
    b++;
}
Console.ReadKey(true);

//All The Methods

//Assigns int 1 to pixels contained within outer rim of clock face
int[,] assignClockFace(int[,] shadingPattern, int a, int b)
{
    //uses [row, column]
    shadingPattern[1 + a, 7 + b] = 1;
    shadingPattern[1 + a, 8 + b] = 1;
    shadingPattern[1 + a, 9 + b] = 1;
    shadingPattern[1 + a, 10 + b] = 1;
    shadingPattern[1 + a, 11 + b] = 1;

    shadingPattern[2 + a, 5 + b] = 1;
    shadingPattern[2 + a, 6 + b] = 1;
    shadingPattern[2 + a, 7 + b] = 1;
    shadingPattern[2 + a, 8 + b] = 1;
    shadingPattern[2 + a, 9 + b] = 1;
    shadingPattern[2 + a, 10 + b] = 1;
    shadingPattern[2 + a, 11 + b] = 1;
    shadingPattern[2 + a, 12 + b] = 1;
    shadingPattern[2 + a, 13 + b] = 1;

    shadingPattern[3 + a, 3 + b] = 1;
    shadingPattern[3 + a, 4 + b] = 1;
    shadingPattern[3 + a, 5 + b] = 1;
    shadingPattern[3 + a, 6 + b] = 1;
    shadingPattern[3 + a, 12 + b] = 1;
    shadingPattern[3 + a, 13 + b] = 1;
    shadingPattern[3 + a, 14 + b] = 1;

    shadingPattern[4 + a, 3 + b] = 1;
    shadingPattern[4 + a, 4 + b] = 1;
    shadingPattern[4 + a, 14 + b] = 1;
    shadingPattern[4 + a, 15 + b] = 1;

    shadingPattern[5 + a, 2 + b] = 1;
    shadingPattern[5 + a, 3 + b] = 1;
    shadingPattern[5 + a, 15 + b] = 1;
    shadingPattern[5 + a, 16 + b] = 1;

    shadingPattern[6 + a, 2 + b] = 1;
    shadingPattern[6 + a, 3 + b] = 1;
    shadingPattern[6 + a, 15 + b] = 1;
    shadingPattern[6 + a, 16 + b] = 1;

    shadingPattern[7 + a, 1 + b] = 1;
    shadingPattern[7 + a, 2 + b] = 1;
    shadingPattern[7 + a, 16 + b] = 1;

    shadingPattern[8 + a, 1 + b] = 1;
    shadingPattern[8 + a, 2 + b] = 1;
    shadingPattern[8 + a, 16 + b] = 1;
    shadingPattern[8 + a, 17 + b] = 1;

    shadingPattern[9 + a, 1 + b] = 1;
    shadingPattern[9 + a, 2 + b] = 1;
    shadingPattern[9 + a, 16 + b] = 1;
    shadingPattern[9 + a, 17 + b] = 1;

    shadingPattern[10 + a, 1 + b] = 1;
    shadingPattern[10 + a, 2 + b] = 1;
    shadingPattern[10 + a, 16 + b] = 1;
    shadingPattern[10 + a, 17 + b] = 1;

    shadingPattern[11 + a, 1 + b] = 1;
    shadingPattern[11 + a, 2 + b] = 1;
    shadingPattern[11 + a, 15 + b] = 1;
    shadingPattern[11 + a, 16 + b] = 1;

    shadingPattern[12 + a, 1 + b] = 1;
    shadingPattern[12 + a, 2 + b] = 1;
    shadingPattern[12 + a, 3 + b] = 1;
    shadingPattern[12 + a, 15 + b] = 1;
    shadingPattern[12 + a, 16 + b] = 1;

    shadingPattern[13 + a, 2 + b] = 1;
    shadingPattern[13 + a, 3 + b] = 1;
    shadingPattern[13 + a, 15 + b] = 1;
    shadingPattern[13 + a, 16 + b] = 1;

    shadingPattern[14 + a, 3 + b] = 1;
    shadingPattern[14 + a, 4 + b] = 1;
    shadingPattern[14 + a, 14 + b] = 1;
    shadingPattern[14 + a, 15 + b] = 1;

    shadingPattern[15 + a, 3 + b] = 1;
    shadingPattern[15 + a, 4 + b] = 1;
    shadingPattern[15 + a, 5 + b] = 1;
    shadingPattern[15 + a, 6 + b] = 1;
    shadingPattern[15 + a, 12 + b] = 1;
    shadingPattern[15 + a, 13 + b] = 1;
    shadingPattern[15 + a, 14 + b] = 1;

    shadingPattern[16 + a, 5 + b] = 1;
    shadingPattern[16 + a, 6 + b] = 1;
    shadingPattern[16 + a, 7 + b] = 1;
    shadingPattern[16 + a, 8 + b] = 1;
    shadingPattern[16 + a, 9 + b] = 1;
    shadingPattern[16 + a, 10 + b] = 1;
    shadingPattern[16 + a, 11 + b] = 1;
    shadingPattern[16 + a, 12 + b] = 1;
    shadingPattern[16 + a, 13 + b] = 1;

    shadingPattern[17 + a, 6 + b] = 1;
    shadingPattern[17 + a, 7 + b] = 1;
    shadingPattern[17 + a, 8 + b] = 1;
    shadingPattern[17 + a, 9 + b] = 1;
    shadingPattern[17 + a, 10 + b] = 1;
    shadingPattern[17 + a, 11 + b] = 1;

    //returns the mod + aified multi dimensional pixel array
    return shadingPattern;
}

//Assigns int 1 to pixels contained withing the hand of the clock
int[,] assignClockHand(int[,] shadingPattern, double width, double theta, double length, int a, int b)
{
    //draws the clock hand for ANY hand
    for (int i = 0; i < Console.WindowHeight; i++)
    {
        // i is equivelent to y and j is equivelent to x
        for (int j = 0; j < Console.WindowWidth / 2; j++)
        {
            //convert height and width to x and y cartesian plane
            int x = j - 9 - b;
            int y = 9 - i - a;

            //checkes to see if cell is within the area of the square
            if (x < 9 && x > -9 && y < 9 && y > -9)
            {
                //Makes the clock hand
                if (
                    calculateHandShadingBounds(theta, width, x, y)
                    && insideClockFace(x, y, length)
                    && inCorrectQuadrant(theta, x, y)
                )
                {
                    shadingPattern[i, j] = 1;
                }
                //break;
            }

            //makes a "Checkerboard" shading pattern when enabled
            // if (i % 2 == j % 2)
            // {
            //     shadingPattern[i, j] = 0;
            // }
            // if (i % 2 != j % 2)
            // {
            //     shadingPattern[i, j] = 1;
            // }
        }
    }
    return shadingPattern;
}

// Checks to see if pixel goes past outer rim of Clock
bool insideClockFace(int x, int y, double length)
{
    // return Math.Sqrt(x * x + y * y) <= length;
    return true;
}

//checks to see if pixel is in correct quadrant
bool inCorrectQuadrant(double theta, int x, int y)
{
    do
    {
        //j is like x, i is like y inverted
        // Quadrant 1
        if (0 <= theta && theta < 90)
        {
            return x > -1 && y > -1;
        }
        // Quadrant 2
        else if (90 <= theta && theta < 180)
        {
            return x <= 0 && y >= 0;
        }
        // Quadrant 3
        else if (180 <= theta && theta < 270)
        {
            return x <= 0 && y <= 0;
        }
        // Quadrant 4
        else if (270 <= theta && theta < 360)
        {
            return x >= 0 && y <= 0;
        }
        // Normalize theta to be within [0, 360)
        else if (theta < 0)
        {
            theta += 360;
        }
        else
        {
            theta -= 360;
        }
    } while (theta >= 360 || theta < 0);

    // Default return value - return false
    return false;
    return true;
}

// Checks to see if a pixel is part of the clock hand
bool calculateHandShadingBounds(double theta, double width, int x, int y)
{
    // Normalize theta to be within [0, 360)
    theta = theta % 360;
    if (theta < 0)
        theta += 360;

    // Clock hand X and Y coordinates at a distance R of the cell (i, j) along the angle Theta
    double R = Math.Sqrt(x * x + y * y);

    // Calculate the end point of a segment of the clock hand at distance R
    double handX = R * Math.Cos(theta * Math.PI / 180); // Convert theta to radians
    double handY = R * Math.Sin(theta * Math.PI / 180);

    // Calculate perpendicular offsets for the width
    double offsetX = (width / 2) * Math.Sin(theta * Math.PI / 180);
    double offsetY = (width / 2) * Math.Cos(theta * Math.PI / 180);

    //Deffine Bounds for the hand
    double minX = handX - offsetX;
    double maxX = handX + offsetX;
    double minY = handY - offsetY;
    double maxY = handY + offsetY;

    //Calculates what coordinate (x or y) to compare to find if the pixel is "in between"
    int quad45 = 0;
    do
    {
        // Quadrant 1 + 45
        if (45 <= theta && theta < 135)
        {
            quad45 = 1;
        }
        // Quadrant 2 + 45
        else if (135 <= theta && theta < 225)
        {
            quad45 = 2;
        }
        // Quadrant 3 + 45
        else if (225 <= theta && theta < 315)
        {
            quad45 = 3;
        }
        // Quadrant 4 + 45
        else if ((315 <= theta && theta < 360) || (0 <= theta && theta < 45))
        {
            quad45 = 4;
        }
    } while (theta >= 360 || theta < 0);

    bool response;

    //Sets the Hands
    switch (quad45)
    {
        case 1:
            //Calculates if the pixel is within the x coordinates of the "clock hand" bounds
            response = x >= Math.Min(minX, maxX) && x <= Math.Max(minX, maxX);
            break;
        case 2:
            //Calculates if the pixel is within the y coordinates of the "clock hand" bounds
            response = y >= Math.Min(minY, maxY) && y <= Math.Max(minY, maxY);
            break;
        case 3:
            //Calculates if the pixel is within the x coordinates of the "clock hand" bounds
            response = x >= Math.Min(minX, maxX) && x <= Math.Max(minX, maxX);
            break;
        case 4:
            //Calculates if the pixel is within the y coordinates of the "clock hand" bounds
            response = y >= Math.Min(minY, maxY) && y <= Math.Max(minY, maxY);
            break;
        default:
            throw new ArgumentException("Invalid value for quadPlus45");
    }

    return response;
}

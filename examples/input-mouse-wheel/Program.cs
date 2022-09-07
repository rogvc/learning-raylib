using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

const int screenWidth = 800;
const int screenHeight = 450;

InitWindow(screenWidth, screenHeight, "Hello, raylib-cs!");

var boxPositionY = screenHeight / 2 - 40;
var scrollSpeed = 4; // Scrolling speed in pixels

SetTargetFPS(60); // Set target FPS (maximum)

while (!WindowShouldClose()) // Detect window close button or ESC key
{
    // Update

    boxPositionY -= (int)(GetMouseWheelMove() * scrollSpeed);

    // Draw
    BeginDrawing();

    ClearBackground(RAYWHITE);

    DrawRectangle(screenWidth / 2 - 40, boxPositionY, 80, 80, MAROON);

    DrawText("Use mouse wheel to move the cube up and down!", 10, 10, 20, GRAY);
    DrawText(String.Format("Box position Y: {0:000}", boxPositionY), 10, 40, 20, LIGHTGRAY);

    EndDrawing();
}

// De-initialization
CloseWindow();        // Close window and OpenGL context

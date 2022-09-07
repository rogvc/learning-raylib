using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

//Initialization
const int screenWidth = 800;
const int screenHeight = 450;

InitWindow(screenWidth, screenHeight, "Hello, raylib-cs!");
SetTargetFPS(60); // Set target FPS (maximum)

while (!WindowShouldClose()) // Detect window close button or ESC key
{
    // Update

    // Draw
    BeginDrawing();

    ClearBackground(RAYWHITE);
    DrawText("Congrats! You're good to go!", 250, 200, 20, DARKGRAY);

    EndDrawing();
}

// De-initialization
CloseWindow();        // Close window and OpenGL context

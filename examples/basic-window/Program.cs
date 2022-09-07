// Using static allows us to refer to a class's public methods and properties 
// without needing to add `<class_name>.` prefix every time.
// In this case, this results in cleaner code!
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

const int screenWidth = 800;
const int screenHeight = 450;

InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

SetTargetFPS(60); // Set target FPS (maximum)

while (!WindowShouldClose()) // Detect window close button or ESC key
{
    // Update
    //--------------------------------------------------------------------------

    // TODO: Update your variables here

    //--------------------------------------------------------------------------

    // Draw
    //--------------------------------------------------------------------------

    BeginDrawing();
    ClearBackground(RAYWHITE);
    DrawText("Congrats! You created your first window!", 190, 200, 20, GRAY);
    EndDrawing();

    //--------------------------------------------------------------------------
}

// De-Initialization
//--------------------------------------------------------------------------------------

CloseWindow();        // Close window and OpenGL context

//--------------------------------------------------------------------------------------

// Using static allows us to refer to a class's public methods and properties 
// without needing to add `<class_name>.` prefix every time.
// In this case, this results in cleaner code!
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

const int screenX = 800;
const int screenY = 450;

InitWindow(screenX, screenY, "raylib [core] example - basic window");

SetTargetFPS(60);

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(RAYWHITE);
    DrawText("Congrats! You created your first window!", 190, 200, 20, GRAY);

    EndDrawing();
}

CloseWindow();
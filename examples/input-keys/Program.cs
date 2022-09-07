using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.KeyboardKey;

const int screenWidth = 800;
const int screenHeight = 450;

InitWindow(screenWidth, screenHeight, "raylib [core] example - keyboard input");

var ballPosition = new Vector2 { X = (float)screenWidth / 2, Y = (float)screenHeight / 2 };

SetTargetFPS(60);

while (!WindowShouldClose())
{
    // Update
    if (IsKeyDown(KEY_RIGHT)) ballPosition.X += 2.0f;
    if (IsKeyDown(KEY_LEFT)) ballPosition.X -= 2.0f;
    if (IsKeyDown(KEY_UP)) ballPosition.Y -= 2.0f;
    if (IsKeyDown(KEY_DOWN)) ballPosition.Y += 2.0f;

    //Draw
    BeginDrawing();

    ClearBackground(RAYWHITE);
    DrawText("Move the ball with the arrow keys", 10, 10, 20, DARKGRAY);
    DrawCircleV(ballPosition, 50, MAROON);
    EndDrawing();
}

CloseWindow();

using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.MouseButton;

const int screenWidth = 800;
const int screenHeight = 450;

InitWindow(screenWidth, screenHeight, "raylib [core] example - mouse input");

var ballPosition = new Vector2 { X = -100.0f, Y = -100.0f };
var ballColor = DARKBLUE;

SetTargetFPS(60);

while (!WindowShouldClose())
{
    // Update
    ballPosition = GetMousePosition();

    if (IsMouseButtonPressed(MOUSE_BUTTON_LEFT)) ballColor = MAROON;
    if (IsMouseButtonPressed(MOUSE_BUTTON_MIDDLE)) ballColor = LIME;
    if (IsMouseButtonPressed(MOUSE_BUTTON_RIGHT)) ballColor = DARKBLUE;
    if (IsMouseButtonPressed(MOUSE_BUTTON_SIDE)) ballColor = PURPLE;
    if (IsMouseButtonPressed(MOUSE_BUTTON_EXTRA)) ballColor = YELLOW;
    if (IsMouseButtonPressed(MOUSE_BUTTON_FORWARD)) ballColor = ORANGE;
    if (IsMouseButtonPressed(MOUSE_BUTTON_BACK)) ballColor = BEIGE;

    // Draw
    BeginDrawing();

    ClearBackground(RAYWHITE);

    DrawCircleV(ballPosition, 40, ballColor);

    DrawText("Move ball with mouse and click mouse button to change color", 10, 10, 20, DARKGRAY);

    EndDrawing();
}

CloseWindow();

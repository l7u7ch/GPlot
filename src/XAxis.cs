using System;
using Godot;

public partial class XAxis : Control
{
    private Font Font = ThemeDB.FallbackFont;
    public float MaxValue = 0;
    public float MinValue = 0;
    public int Digits = 3;
    public int FontSize = 12;
    public int Ticks = 3;

    public override void _Draw()
    {
        float Unit = (MaxValue - MinValue) / Ticks;

        for (int i = 0; i <= Ticks; i++)
        {
            float _X = Size.X / Ticks * i;
            float _Y = Font.GetAscent() - Font.GetDescent();
            DrawString( //
                font: Font,
                pos: new(_X, _Y),
                text: Math.Round(i * Unit + MinValue, Digits).ToString(),
                fontSize: FontSize
            );
        }
    }
}

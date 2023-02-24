using Azimuth;
using Azimuth.GameObjects;

using Raylib_cs;

using System.Numerics;

namespace Spasteroids.UI
{
	public class Button : GameObject
	{
		private Vector2 size;
		private string text;
		private Color color;
		private Font font;
		private int fontSize;
		private Vector2 textSize;

		public Button(Vector2 _position, Vector2 _size, string _text)
		{
			position = _position;
			size = _size;
			text = _text;
			color = Color.LIGHTGRAY;
			font = Assets.Find<Font>("Fonts/poxel");
			fontSize = 100;
			textSize = Raylib.MeasureTextEx(font, text, fontSize, 1f) * 0.5f;
			textSize.Y = 0;
		}

		public override void Draw()
		{
			Raylib.DrawRectanglePro(new Rectangle(position.X, position.Y, size.X, size.Y), size * 0.5f, 0f, Color.PINK);
		
			Raylib.DrawTextPro(font, text, position + textSize, size * 0.5f, 0, fontSize, 1f, Color.BLACK);
		}

		public override void Update(float _deltaTime) { }
	}
}
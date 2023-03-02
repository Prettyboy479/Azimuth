using Raylib_cs;

using System.Numerics;

namespace Azimuth.UI
{
	public class Widget
	{
		public Rectangle Bounds => new Rectangle(position.X, position.Y, size.X, size.Y);
		
		public Vector2 position;
		public Vector2 size;
		public bool focused;
		protected int drawLayer;
		protected Widget(Vector2 _position, Vector2 _size)
		{
			position = _position;
			size = _size;
		}

		public virtual void Draw()
		{
			Raylib.DrawRectangleRec(Bounds, Color.BLUE);
		}

		public virtual void Update(Vector2 _mousePos)
		{
			focused = Raylib.CheckCollisionPointRec(_mousePos, Bounds);
		}
		//overidden from system.object - wheneever a widget is used in string interpolation or 
		//anhy sort of string operations, this will be called
		public override string ToString()
		{
			return $"Widget:\n Position: {position}\n Size: {size}\n Draw Layer {drawLayer}\n Focused: {focused}";
		}
	}
}
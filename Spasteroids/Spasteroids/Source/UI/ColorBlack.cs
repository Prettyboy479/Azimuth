using Raylib_cs;
namespace Spasteroids.UI
{
	public struct ColorBlack
	{
		public Color normal;
		public Color hovered;
		public Color pressed;
		public Color disabled;

		public ColorBlack(Color _normal, Color _hovered, Color _pressed, Color _disabled)
		{
			normal = _normal;
			hovered = _hovered;
			pressed = _pressed;
			disabled = _disabled;
		}
		
	}
}
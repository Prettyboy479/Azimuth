using Raylib_cs;

using Azimuth;

namespace Azimuth_Test
{
	public static class Program
	{
		public static void Main()
		{
			Application.Run(800, 600, "Azimuth Test", Color.BLACK, new AzimuthTestGame());
		}
	}

}


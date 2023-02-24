using Azimuth.GameObjects;

using Raylib_cs;

using Temp.GameStates;

namespace Temp
{
	public sealed class Application
	{
		public static Application Instance { get; private set; }

		public static void Run(int _width, int _height, string _title, Color _color, Game _game)
		{
			Application app = new Application(_width, _height, _title, _color, _game);
			app.Run();
		}
		public Window Window { get; }
		private readonly Game game;
	
		private Application(int _width, int _height, string _name, Color _color, Game _game)
		{
			Window = new Window(_width, _height, _name, _color);
			
			game = _game;
		}

		private void Run()
		{
			Window.Open();
			Assets.Load();
			game.Load();
			while(!Raylib.WindowShouldClose())
			{
				float deltaTime = Raylib.GetFrameTime();
				GamObjectManager.Update(deltaTime);
				GameStateManager.Update(deltaTime);
				Raylib.BeginDrawing();
				Window.Clear();
				GamObjectManager.Draw();
				GameStateManager.Draw();
				Raylib.EndDrawing();
			}
			game.Unload();
			Assets.Unload();
			Window.Close();
		}
	}
}
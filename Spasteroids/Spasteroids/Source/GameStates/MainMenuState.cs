using Azimuth;
using Azimuth.GameObjects;
using Azimuth.GameStates;

using Spasteroids.UI;

using System.Numerics;

namespace Spasteroids.GameStates
{
	public class MainMenuState : IGameState
	{
		public string ID => "Main Menu";
		private Button playButton;
		public void Load()
		{
			int screenWidth = Application.Instance.Window.Width;
			int screenHeight = Application.Instance.Window.Height;
			int sizeX = screenWidth / 2;
			int sizeY = 100;
			int posX = screenWidth / 2;
			int posY = screenHeight / 2 - sizeY / 2;
			playButton = new Button(new Vector2(posX, posY), new Vector2(sizeX, sizeY), "Play");
			GamObjectManager.Spawn(playButton);
		}

		public void Update(float _deltaTime) { }

		public void Draw() { }

		public void Unload() { }
	}
}
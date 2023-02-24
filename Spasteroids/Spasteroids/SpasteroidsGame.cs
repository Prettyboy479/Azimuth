using Azimuth;
using Azimuth.GameStates;

using Raylib_cs;

using Spasteroids.GameStates;

namespace Spasteroids
{
	public class SpasteroidsGame : Game
	{
		public override void Load()
		{
			Raylib.InitAudioDevice();
			GameStateManager.AddState(new MainMenuState());
			GameStateManager.AddState(new PlayState());
			
			GameStateManager.ActivateState("Main Menu");
		}

		public override void Unload()
		{
			Raylib.CloseAudioDevice();
		}
	}
}
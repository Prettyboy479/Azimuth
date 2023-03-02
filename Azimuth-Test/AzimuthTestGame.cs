using Azimuth;
using Azimuth.GameObjects;
using Azimuth.UI;

using Raylib_cs;

using System.Numerics;

namespace Azimuth_Test
{
	public class AzimuthTestGame : Game
	{
		private ImageWidget image;
		private Button button;
		public override void Load()
		{
			int counter = 0;
			image = new ImageWidget(Vector2.Zero, new Vector2(200, 200), "3esnra");
			button = new Button(Vector2.Zero, new Vector2(150, 75), Button.RenderSettings.normal);
			button.SetDrawLayer(100);
			button.AddListener(OnClickButton);
			button.AddListener(() =>
			{
				if(counter % 2 == 0)
				{
					UIManager.Add(image);
					
				}
				else
				{
					UIManager.Remove(image);
				}

				counter++;
			});
			UIManager.Add(button);
		}

		private void OnClickButton()
		{
			Console.WriteLine("Hello world!");
		}
		public override void Draw()
		{
			button.Draw();
			//image.Draw();
		}

		public override void Update(float _deltaTime)
		{
			button.Update(Raylib.GetMousePosition());
			//image.Update(Raylib.GetMousePosition());
		}

		public override void Unload()
		{
			
		}
	}
}
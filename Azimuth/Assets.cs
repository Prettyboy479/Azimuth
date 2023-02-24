using Raylib_cs;

using System.Runtime.Loader;

namespace Temp
{
	public static class Assets
	{
		private static Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();
		private static Dictionary<string, Image> images = new Dictionary<string, Image>();
		private static Dictionary<string, Sound> sounds = new Dictionary<string, Sound>();
		private static Dictionary<string, Font> fonts = new Dictionary<string, Font>();

		public static ASSET_TYPE Find<ASSET_TYPE>(string _id)
		{
			if(_id.Contains("Textures") && textures.ContainsKey(_id))
			{
				return (ASSET_TYPE) Convert.ChangeType(textures[_id], typeof(ASSET_TYPE));
			}

			if(_id.Contains("Images") && images.ContainsKey(_id))
			{
				return (ASSET_TYPE) Convert.ChangeType(images[_id], typeof(ASSET_TYPE));
			}

			if(_id.Contains("Sounds") && sounds.ContainsKey(_id))
			{
				return (ASSET_TYPE) Convert.ChangeType(sounds[_id], typeof(ASSET_TYPE));
			}

			if(_id.Contains("Fonts") && fonts.ContainsKey(_id))
			{
				return (ASSET_TYPE) Convert.ChangeType(fonts[_id], typeof(ASSET_TYPE));
			}
		}

		public static void Load()
		{
			
		}
		public static void Unload()
		{
			ClearMemoryFor<Texture2D>(textures, Raylib.UnloadTexture);
			ClearMemoryFor<Image>(images, Raylib.UnloadImage);
			ClearMemoryFor<Sound>(sounds, Raylib.UnloadSound);
			ClearMemoryFor<Font>(fonts, Raylib.UnloadFont);
		}

		private static void ClearMemoryFor<ASSET_TYPE>(Dictionary<string, ASSET_TYPE> _assets, Action<ASSET_TYPE> _unloadFnc)
		{
			foreach(ASSET_TYPE asset in _assets.Values)
			{
				_unloadFnc(asset);
			}
			_assets.Clear();
		}
	}
}
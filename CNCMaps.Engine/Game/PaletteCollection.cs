using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CNCMaps.Engine.Rendering;
using CNCMaps.FileFormats;
using CNCMaps.FileFormats.VirtualFileSystem;
using CNCMaps.Shared;

namespace CNCMaps.Engine.Game {
	public class PaletteCollection : IEnumerable<Palette> {
		public List<Palette> CustomPalettes = new List<Palette>();
		public Palette IsoPalette, OvlPalette, UnitPalette, AnimPalette;

		internal Palette GetPalette(PaletteType paletteType) {
			switch (paletteType) {
				case PaletteType.Anim: return AnimPalette;
				case PaletteType.Overlay: return OvlPalette;
				case PaletteType.Unit: return UnitPalette;
				case PaletteType.Custom:
					throw new ArgumentException("GetPalette only works on built-in default palettes");
				case PaletteType.Iso:
				default:
					return IsoPalette;
			}
		}

		public IEnumerator<Palette> GetEnumerator() {
			var p = new List<Palette> {
				IsoPalette, 
				OvlPalette, 
				UnitPalette, 
				AnimPalette
			};
			p.AddRange(CustomPalettes);
			return p.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}
		
		/// <summary>
		/// Gets a custom palette from collection. If custom palette is not found, creates one, adds it to the collection and returns it.
		/// Search is done by comparing names of the palettes.
		/// </summary>
		/// <param name="paletteName">Name of the palette to find, without theater or .pal extension.</param>
		/// <returns>The correct custom palette.</returns>
		public Palette GetCustomPalette(string paletteName) {
			string fileName;
			if (paletteName.ToLower().EndsWith(".pal")) // full name already given
				fileName = paletteName; 
			else // filename = <paletteName><theaterExtension>.pal (e.g. lib<tem/sno/urb>.pal)
				fileName = paletteName + ModConfig.ActiveTheater.Extension.Substring(1) + ".pal";

			var pal = CustomPalettes.FirstOrDefault(p => p.Name == paletteName);
			if (pal == null) {
				// palette hasn't been loaded yet
				pal = new Palette(VFS.Open<PalFile>(fileName), paletteName);
				CustomPalettes.Add(pal);
			}
			return pal;
		}

	}
}
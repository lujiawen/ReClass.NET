﻿using System;
using System.Collections.Generic;
using System.Drawing;
using ReClassNET.Memory;

namespace ReClassNET.UI
{
	public class ViewInfo
	{
		public Settings Settings { get; set; }

		public Graphics Context { get; set; }
		public FontEx Font { get; set; }

		public MemoryBuffer Memory { get; set; }

		public Rectangle ClientArea { get; set; }
		public List<HotSpot> HotSpots { get; set; }
		public List<Nodes.ClassNode> Classes { get; set; }
		public IntPtr Address { get; set; }
		public int Level { get; set; }
		public bool MultipleNodesSelected { get; set; }

        public CompareOptions ShowOptions { get; set; } = new CompareOptions();
        public object Tag { get; set; }
        public object Tag2 { get; set; }

        public ViewInfo Clone()
		{
			return new ViewInfo
			{
				Settings = Settings,
				Context = Context,
				Font = Font,
				Memory = Memory,
				ClientArea = ClientArea,
				HotSpots = HotSpots,
				Classes = Classes,
				Address = Address,
				Level = Level,
				MultipleNodesSelected = MultipleNodesSelected,
                Tag = Tag,
                Tag2 = Tag2,
                ShowOptions = ShowOptions
            };
		}
	}
}

﻿using System.Drawing;
using System.Globalization;
using ReClassNET.Extensions;
using ReClassNET.Memory;
using ReClassNET.UI;
using ReClassNET.Util;

namespace ReClassNET.Nodes
{
	public class Int16Node : BaseNumericNode
	{
		public override int MemorySize { get; set; } = 2;

		public override Size Draw(ViewInfo view, int x, int y)
		{
			var value = ReadValueFromMemory(view.Memory);
			return DrawNumeric(view, x, y, Icons.Signed, "Int16", value.ToString(), $"0x{value:X}");
		}

		public override void Update(HotSpot spot)
		{
			base.Update(spot);

			if (spot.Id == 0 || spot.Id == 1)
			{
				if (short.TryParse(spot.Text, out var val) || spot.Text.TryGetHexString(out var hexValue) && short.TryParse(hexValue, NumberStyles.HexNumber, null, out val))
				{
					spot.Memory.Process.WriteRemoteMemory(spot.Address, val);
				}
			}
		}

		public short ReadValueFromMemory(MemoryBuffer memory)
		{
			return memory.ReadInt16(Offset);
		}
	}
}

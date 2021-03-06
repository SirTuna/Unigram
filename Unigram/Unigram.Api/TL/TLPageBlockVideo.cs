// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockVideo : TLPageBlockBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Autoplay = (1 << 0),
			Loop = (1 << 1),
		}

		public bool IsAutoplay { get { return Flags.HasFlag(Flag.Autoplay); } set { Flags = value ? (Flags | Flag.Autoplay) : (Flags & ~Flag.Autoplay); } }
		public bool IsLoop { get { return Flags.HasFlag(Flag.Loop); } set { Flags = value ? (Flags | Flag.Loop) : (Flags & ~Flag.Loop); } }

		public Flag Flags { get; set; }
		public Int64 VideoId { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockVideo() { }
		public TLPageBlockVideo(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PageBlockVideo; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			VideoId = from.ReadInt64();
			Caption = TLFactory.Read<TLRichTextBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xD9D71866);
			to.Write((Int32)Flags);
			to.Write(VideoId);
			to.WriteObject(Caption, cache);
			if (cache) WriteToCache(to);
		}
	}
}
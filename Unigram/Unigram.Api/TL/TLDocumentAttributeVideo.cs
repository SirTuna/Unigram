// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocumentAttributeVideo : TLDocumentAttributeBase 
	{
		public Int32 Duration { get; set; }
		public Int32 W { get; set; }
		public Int32 H { get; set; }

		public TLDocumentAttributeVideo() { }
		public TLDocumentAttributeVideo(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeVideo; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Duration = from.ReadInt32();
			W = from.ReadInt32();
			H = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x5910CCCB);
			to.Write(Duration);
			to.Write(W);
			to.Write(H);
			if (cache) WriteToCache(to);
		}
	}
}
using System.Collections;
using System.Collections.Generic;

public class pt_req_look_other_guild_bonfire_d740 : st.net.NetBase.Pt {
	public pt_req_look_other_guild_bonfire_d740()
	{
		Id = 0xD740;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_look_other_guild_bonfire_d740();
	}
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		return writer.data;
	}

}

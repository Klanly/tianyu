using System.Collections;
using System.Collections.Generic;

public class pt_req_quell_demon_info_c146 : st.net.NetBase.Pt {
	public pt_req_quell_demon_info_c146()
	{
		Id = 0xC146;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_quell_demon_info_c146();
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

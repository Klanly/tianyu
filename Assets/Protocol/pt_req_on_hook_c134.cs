using System.Collections;
using System.Collections.Generic;

public class pt_req_on_hook_c134 : st.net.NetBase.Pt {
	public pt_req_on_hook_c134()
	{
		Id = 0xC134;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_on_hook_c134();
	}
	public uint state;
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
		state = reader.Read_uint();
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		writer.write_int(state);
		return writer.data;
	}

}

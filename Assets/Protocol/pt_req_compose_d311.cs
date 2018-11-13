using System.Collections;
using System.Collections.Generic;

public class pt_req_compose_d311 : st.net.NetBase.Pt {
	public pt_req_compose_d311()
	{
		Id = 0xD311;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_compose_d311();
	}
	public int id;
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
		id = reader.Read_int();
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		writer.write_int(id);
		return writer.data;
	}

}

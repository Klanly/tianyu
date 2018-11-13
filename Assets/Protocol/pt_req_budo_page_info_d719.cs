using System.Collections;
using System.Collections.Generic;

public class pt_req_budo_page_info_d719 : st.net.NetBase.Pt {
	public pt_req_budo_page_info_d719()
	{
		Id = 0xD719;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_budo_page_info_d719();
	}
	public int type;
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
		type = reader.Read_int();
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		writer.write_int(type);
		return writer.data;
	}

}

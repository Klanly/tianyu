using System.Collections;
using System.Collections.Generic;

public class pt_req_operation_activity_info_d902 : st.net.NetBase.Pt {
	public pt_req_operation_activity_info_d902()
	{
		Id = 0xD902;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_operation_activity_info_d902();
	}
	public uint id;
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
		id = reader.Read_uint();
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		writer.write_int(id);
		return writer.data;
	}

}

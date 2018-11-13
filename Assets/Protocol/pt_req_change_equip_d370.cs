using System.Collections;
using System.Collections.Generic;

public class pt_req_change_equip_d370 : st.net.NetBase.Pt {
	public pt_req_change_equip_d370()
	{
		Id = 0xD370;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_req_change_equip_d370();
	}
	public int id;
	public int action;
	public int quik_buy;
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
		id = reader.Read_int();
		action = reader.Read_int();
		quik_buy = reader.Read_int();
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		writer.write_int(id);
		writer.write_int(action);
		writer.write_int(quik_buy);
		return writer.data;
	}

}

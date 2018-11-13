using System.Collections;
using System.Collections.Generic;

public class pt_update_budo_apply_d721 : st.net.NetBase.Pt {
	public pt_update_budo_apply_d721()
	{
		Id = 0xD721;
	}
	public override st.net.NetBase.Pt createNew()
	{
		return new pt_update_budo_apply_d721();
	}
	public int state;
	public override void fromBinary(byte[] binary)
	{
		reader = new st.net.NetBase.ByteReader(binary);
		state = reader.Read_int();
	}

	public override byte[] toBinary()
	{
		writer = new st.net.NetBase.ByteWriter();
		writer.write_int(state);
		return writer.data;
	}

}

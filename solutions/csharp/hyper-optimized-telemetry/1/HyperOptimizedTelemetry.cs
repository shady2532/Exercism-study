using System.Reflection.Metadata.Ecma335;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte prefix;
        byte[] data;

        if (reading >= 0)
        {
            if (reading <= 65_535) { prefix = 2; data = BitConverter.GetBytes((ushort)reading); }
            else if (reading <= 2_147_483_647) { prefix = 256 - 4; data = BitConverter.GetBytes((int)reading); }
            else if (reading <= 4_294_967_295) { prefix = 4; data = BitConverter.GetBytes((uint)reading); }
            else { prefix = 256 - 8; data = BitConverter.GetBytes(reading); }
        }
        else
        {
            if (reading >= -32_768) { prefix = 256 - 2; data = BitConverter.GetBytes((short)reading); }
            else if (reading >= -2_147_483_648) { prefix = 256 - 4; data = BitConverter.GetBytes((int)reading); }
            else { prefix = 256 - 8; data = BitConverter.GetBytes(reading); }
        }
        byte[] buffer = new byte[9]; // Always 9 bytes total
        buffer[0] = prefix;
        Array.Copy(data, 0, buffer, 1, data.Length);
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];

        return prefix switch
        {
            2 => BitConverter.ToUInt16(buffer, 1),     // ushort
            4 => BitConverter.ToUInt32(buffer, 1),      // int (signed)
            252 => BitConverter.ToInt32(buffer, 1),   // uint (unsigned)
            254 => BitConverter.ToInt16(buffer, 1),    // short (signed)
            248 => BitConverter.ToInt64(buffer, 1),    // long (signed)
            _ => 0
        };
    }
}

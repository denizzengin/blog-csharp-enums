namespace EnumsSample;

[Flags]
public enum StudentType : byte
{
    Unknown = 1,
    Primary = 1 << 1,
    College = 1 << 2,
    Univertsity = 1 << 3,
}

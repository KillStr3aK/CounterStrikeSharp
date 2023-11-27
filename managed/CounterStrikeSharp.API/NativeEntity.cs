using CounterStrikeSharp.API.Modules.Utils;

namespace CounterStrikeSharp.API;

public abstract class NativeEntity : NativeObject
{
    public new IntPtr Handle => NativeAPI.GetEntityPointerFromRef(EntityHandle.Raw);
    public CEntityHandle EntityHandle { get; }

    public NativeEntity(IntPtr pointer) : base(pointer)
    {
        EntityHandle = new(NativeAPI.GetRefFromEntityPointer(pointer));
    }

    public NativeEntity(uint rawHandle) : base(NativeAPI.GetEntityPointerFromRef(rawHandle))
    {
        EntityHandle = new(rawHandle);
    }
}